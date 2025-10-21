namespace ScreenlessGame;

public class Sprite(int x, int y, int width, int height)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Width { get; set; } = width;
    public int Height { get; set; } = height;

    public bool Collides(Sprite otherSprite){
        if (this.X > otherSprite.X + otherSprite.Width){
            return false;
        }
        if (this.X + this.Width < otherSprite.X){
            return false;
        }
        if (this.Y > otherSprite.Y + otherSprite.Height){
            return false;
        }
        if (this.Y + this.Height < otherSprite.Y){
            return false;
        }
        return true;
    }
}
