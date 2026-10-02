namespace StefanBestammerTetris;
using Raylib_cs;
public class Block
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Size { get; set; }
    public Color Color { get; set; }
    
    public Block(float x, float y, float size, Color color)
    {
        X = x;
        Y = y;
        Size = size;
        Color = color;
    }

    public void Update()
    {
        Y += 2;
    }

    public void Draw()
    {
        Raylib.DrawRectangle((int)X, (int)Y, (int)Size, (int)Size, Color);
    }
}