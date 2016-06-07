public class ScreenFactory
{
    public Screen CreateScreen (int size, int resolution)
    {
        return new Screen
        {
            Size = size,
            Resolution = resolution
        };
    }
}