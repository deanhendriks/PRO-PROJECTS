using System;

public class star : bassisclass
{
public int duration = 2;

public bool HitEnemy = false;

    public void onHit()
    {
        bool HitEnemy = true;
        if(HitEnemy==true){
             Console.WriteLine("Hit Enemy " + duration + " seconden");
        }
    }
}
