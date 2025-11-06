
[Flags]
enum Permission
{
    None   = 0b000,
    Delete = 0b001,
    Read   = 0b010,
    Write  = 0b100,
    All    = 0b111
}

enum AccountType
{
    Guest = Permission.Read,
    User = Permission.Read | Permission.Write,
    Moderator = Permission.All
}


static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest:
                return Permission.Read;
            case AccountType.User:
                return Permission.Read | Permission.Write;
            case AccountType.Moderator:
                return Permission.All;
            default:
                return Permission.None;
        }
    }


    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return ( current & check ) == check;
    }
}
