namespace ScreenlessGame;

public class Sprite
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Sprite(int x, int y, int width,int height){
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
    public bool collides(Sprite otherSprite){
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
