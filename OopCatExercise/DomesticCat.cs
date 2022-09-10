using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        private string _setting = "domestic";
        private int _averageHeight = 23;

        public string Setting
            { get { return _setting; } set { _setting = value; } }          
        
        public int AverageHeight 
            { get { return _averageHeight; } set { _averageHeight = value; } }

        public override string Eat()
        {
            return WillComment() ? "Purrrrrrr" : "Purrrrrrr.  It will do I suppose.";
            //return "Purrrrrrr";
        }        

        private bool WillComment()
        {
            Random rnd = new Random();
            return rnd.Next(0,2) == 1;
        }
    }
}
