public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object other)
    {
        if (ReferenceEquals(this, other)) return true;
        if (other is null) return false;
        if (other is not FacialFeatures o) return false;
        return EyeColor == o.EyeColor && PhiltrumWidth == o.PhiltrumWidth;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine( this.EyeColor, this.PhiltrumWidth );
    }    
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object other)
    {
        if (ReferenceEquals(this, other)) return true;
        if (other is null) return false;
        if (other is not Identity o) return false;
        return Email == o.Email &&
               ((FacialFeatures == null && o.FacialFeatures == null) ||
                (FacialFeatures != null && FacialFeatures.Equals(o.FacialFeatures)));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Email, this.FacialFeatures);
    }

}

public class Authenticator
{
    HashSet<Identity> authenticator= new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        if( ( faceA.EyeColor == faceB.EyeColor ) && ( faceA.PhiltrumWidth == faceB.PhiltrumWidth ) ) {
            return true;
        }
        else{
            return false;
        }
    }

    public bool IsAdmin(Identity identity)
    {
        if ( identity.Email == "admin@exerc.ism" ) {
            if( ( identity.FacialFeatures.EyeColor == "green" ) && ( identity.FacialFeatures.PhiltrumWidth == 0.9m ) ){
                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }

    }

    public bool Register(Identity identity)
    {
        if ( authenticator.Add( identity ) ) {
            return true;
        }
        else {
            return false;
        }
    }

    public bool IsRegistered(Identity identity)
    {
        if ( authenticator.Contains( identity ) ) {
            return true;
        }
        else {
            return false;
        }
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals( identityA, identityB );
    }
}
