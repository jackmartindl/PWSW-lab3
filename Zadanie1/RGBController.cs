namespace Zadanie1;

public class RGBController
{
    public static void InitializeColor(RGB color, int R_value, int G_value, int B_value)
    {
        color.BValue = B_value;
        color.GValue = G_value;
        color.RValue = R_value;
    }

    public static void ShowColorParameters(RGB color)
    {
        Console.WriteLine("[" + color.RValue + ", " + color.GValue + ", " + color.BValue + "]");
    }

    public static RGB MixColors(RGB firstColor, RGB secondColor)
    {
        return new RGB(
            AddColors(firstColor.RValue, secondColor.RValue),
            AddColors(firstColor.GValue, secondColor.GValue),
            AddColors(firstColor.BValue, secondColor.BValue)
        );
    }

    private static int AddColors(int firstColor, int secondColor)
    {
        int sumOfColors = firstColor + secondColor;

        if (sumOfColors > 255)
        {
            sumOfColors = 255;
        } else if (sumOfColors < 0)
        {
            sumOfColors = 0;
        }

        return sumOfColors;
    }
}

