class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int battery = 100;
    private int i = 0;

    public RemoteControlCar(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven() => speed*i;

    public void Drive()
    {
        if (!BatteryDrained()) {
            i++;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    private int distance;

    public RaceTrack (int distance) {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do {
            car.Drive();
        } while (car.BatteryDrained()==false);
        return distance <= car.DistanceDriven();
    }
}
