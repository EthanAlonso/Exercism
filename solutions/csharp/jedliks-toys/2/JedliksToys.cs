class RemoteControlCar
{
    private int _meters = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_meters} meters";

    public string BatteryDisplay()
    {
        if (_battery == 0) {
            return $"Battery empty";
        }
        return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery > 0) {
            _battery = _battery - 1;
            _meters = _meters + 20;
        }
    
    }
}
