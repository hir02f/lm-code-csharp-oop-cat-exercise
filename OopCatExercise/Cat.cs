using System;
using System.Drawing;

namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        private bool _isAsleep = false;
        
        public bool IsAsleep
		{
            get { return _isAsleep; }
            set { _isAsleep = value; }           
		}
       
        public void GoToSleep()
        {
            _isAsleep = true;
        }

        public void WakeUp()
        {
            _isAsleep = false;
        }

        public abstract string Eat();        
    }
}
