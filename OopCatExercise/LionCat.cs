using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        private int _averageHeight = 1100;
        public int AverageHeight
        { get { return _averageHeight; } set { _averageHeight = value; } }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}
