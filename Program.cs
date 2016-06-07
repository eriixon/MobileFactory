
    public class MobileCreating
    {
        public static void Main(string[] args)
    {
        var chinaScreenFactory = new ScreenFactory();
        var i14 = chinaScreenFactory.CreateScreen(14, 720);
        var taiwanScreenfactory = new ScreenFactory();
        var i15 = taiwanScreenfactory.CreateScreen(15, 1024);

        var japanBatteryFactory = new BatteryFactory();
        var liIon = japanBatteryFactory.CreateBattery(400, "li-ion");
        var koreaBatteryFactory = new BatteryFactory();
        var nicd = koreaBatteryFactory.CreateBattery(500, "NiCd");

        var Apple = new MobileFactory();
        var iPhone = GetIPhone(Apple);

        var Sumsung = new MobileFactory();
        var Galaxy = Sumsung.CreateMobile("Sumsung", 128, 5, 720, 500, "NiCd");



    }

    private static Mobile GetIPhone(MobileFactory Apple)
    {
        return Apple.CreateMobile("Apple", 64, 6, 1024, 400, "liIon");
    }
}

