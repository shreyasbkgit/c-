static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake){
            return false;
        }
        else{
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake){
            return true;
        }
        if (archerIsAwake){
            return true;
        }
        if (prisonerIsAwake){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(prisonerIsAwake){
            if(archerIsAwake){
                return false;
            }
            else{
                return true;
            }
        }
        else {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        
        if(petDogIsPresent){
            if(!archerIsAwake){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            if((prisonerIsAwake)&&(!archerIsAwake)&&(!knightIsAwake)){
                return true;
            }
            else{
                return false;
            }
        }
        return false;
    }
}
