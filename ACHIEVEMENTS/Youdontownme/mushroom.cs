using System;

public class mushroom : bassisclass
{
    public int powerboost = 1;
    public int growUp = 2;

    public void boost()
    {
        
        if(pickup==true){
            Console.WriteLine("Pak iets op");
            pickup = false;
        }

         bool boost = true;
        if(boost==true){
             Console.WriteLine("Powerboost");
        }
    }
}