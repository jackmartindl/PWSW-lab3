namespace Zadanie1;

public static class Program
{
    public static void Main(string[] args)
    {
        var color1 = new RGB();
        var color2 = new RGB();
        RGBController.InitializeColor(color1, 243, 44, 56);
        RGBController.InitializeColor(color2, 56, 4, 2);
        RGBController.ShowColorParameters(color1);
        RGBController.ShowColorParameters(color2);
        var color3 = RGBController.MixColors(color1, color2);
        RGBController.ShowColorParameters(color3);
    }
}

