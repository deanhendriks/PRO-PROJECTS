using System;

public class banana : bassisclass
{
    public bool slip = false;
    public int duration = 2;

    public void slippery()
    {
        bool slip = true;
        if(slip==true){
        Console.WriteLine("Hij slipt " + duration + " seconden");
        }
    }
}
