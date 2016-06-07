public class MobileFactory
{
    public ScreenFactory ScreenFactory {get; set;}
    public BatteryFactory BatteryFactory { get; set; }

    public new Mobile CreateMobile (string maker, int memory, int size, int resolution, int volume, string material)
    {
        var screen = ScreenFactory.CreateScreen(size, resolution);
        var battery = BatteryFactory.CreateBattery(volume, material);
        
        return new Mobile
        {
            Maker = maker,
            Memory = memory,
            Screen = screen,
            Battery = battery

        };
    }
}