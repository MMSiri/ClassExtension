using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExtension
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] ostrichEggs = new Egg[numberOfEggs];

            for (int i = 0; i < numberOfEggs; i++)
            {
                ostrichEggs[i] = new Egg(Randomizer.NextDouble() + 12, "speckled");
            }
            return ostrichEggs;
        }
    }
}
