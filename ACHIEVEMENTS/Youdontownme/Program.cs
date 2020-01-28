using System;

namespace Youdontownme
{
    class Program
    {
        static void Main(string[] args)
        {
            bassisclass myBasisClass = new bassisclass();
            mushroom myMushroom = new mushroom();
            star myStar = new star();
            banana myBanana = new banana();

            myStar.onHit();
            myMushroom.boost();
            myBanana.slippery();
        }
    }
}
