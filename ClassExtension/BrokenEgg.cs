using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExtension
{
    class BrokenEgg : Egg
    {
        public BrokenEgg(string colour) : base(0, $"broken {colour}")
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
