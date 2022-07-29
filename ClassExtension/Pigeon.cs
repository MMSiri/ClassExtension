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
                pigeonEggs[i] = new Egg(Randomizer.NextDouble() * 2 + 1, "white");
            }
            return pigeonEggs;
        }
    }
}
