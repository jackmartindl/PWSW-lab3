namespace Zadanie1;

public class RGB
{
    private int R_value;
    private int G_value;
    private int B_value;

    public RGB(int rValue, int gValue, int bValue)
    {
        R_value = rValue;
        G_value = gValue;
        B_value = bValue;
    }

    public RGB()
    {
        
    }

    public int RValue
    {
        get => R_value;
        set => R_value = value;
    }

    public int GValue
    {
        get => G_value;
        set => G_value = value;
    }

    public int BValue
    {
        get => B_value;
        set => B_value = value;
    }
}