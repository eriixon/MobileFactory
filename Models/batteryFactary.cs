public class BatteryFactory
{
    public Battery CreateBattery (int volume, string material)
    {
        return new Battery
        {
            Volume = volume,
            Material = material
        };
    }
}