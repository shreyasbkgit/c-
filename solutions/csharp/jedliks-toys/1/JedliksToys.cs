class RemoteControlCar
{
    int driven = 0;
    int battery = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new();
        return car;
    }

    public string DistanceDisplay()
    {
        return "Driven " + (20 * ( this.driven ) ) + " meters";
    }

    public string BatteryDisplay()
    {
        if ( this.battery > 0){
            return "Battery at " + ( this.battery ) + "%" ;
        }
        else{
            return "Battery empty"  ;
        }
        
    }

    public void Drive()
    {
        if ( this.battery > 0){
            this.driven++;
            this.battery--;
        }

    }
}
