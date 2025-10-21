namespace ScreenlessGame;

public class Game
{
    public Game(){
        Console.WriteLine("running!");
        Screen screen = new Screen(800,600);
        Sprite player = new Sprite(100,200,50,50);
        Sprite opponent = new Sprite(100,175,50,50);
        while(true){
            if (player.collides(opponent)){
                Console.WriteLine("Collision!");
                break;
            }
        }
    }
}
