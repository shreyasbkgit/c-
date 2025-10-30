class RemoteControlCar
{
    int speed, batteryDrain;
    int battery, distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.distance = 0;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distance += speed;
            battery -= batteryDrain;
        }
    }


    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar( 50 , 4 );
    }
}

class RaceTrack
{
    int Distance;

    public RaceTrack( int distance ){
        this.Distance = distance ;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!(car.BatteryDrained())){
            car.Drive();
        }
        if(car.DistanceDriven() >= this.Distance) return true;
        else return false;
    }
}
