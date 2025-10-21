namespace ScreenlessGame;

public class Game
{
    public Game(){
        Console.WriteLine("running!");
        Screen screen = new(800,600);
        Sprite player = new(100,200,50,50);
        Sprite opponent = new(100,500,50,50);
        while(true){
            if (player.Collides(opponent)){
                Console.WriteLine("Collision!");
                break;
            }
        }
    }
}
