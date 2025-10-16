class RemoteControlCar
{
    private int speed;
    private double batteryDrain;
    private double batteryState = 100;
    private int metersDriven = 0;

    public RemoteControlCar(int speed, double batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (this.batteryState == 0 || this.batteryDrain > this.batteryState) {
            return true;
        } 
        return false;
    }

    public int DistanceDriven()
    {
        return this.metersDriven;
    }

    public void Drive()
    {
        if (this.BatteryDrained()){
            return;
        } else {
            this.metersDriven += this.speed;
            this.batteryState -= this.batteryDrain; 
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance = 0;

    public RaceTrack(int distance) {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {
            car.Drive();
            if (this.distance <= car.DistanceDriven()) {
                return true;
            }
        }
        return false;
    }
}
