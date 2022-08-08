using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExtension
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] pigeonEggs = new Egg[numberOfEggs];

            for (int i = 0; i < numberOfEggs; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    pigeonEggs[i] = new BrokenEgg("white");
                }
                else
                {
                    pigeonEggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
                }
            }
            return pigeonEggs;
        }
    }
}
