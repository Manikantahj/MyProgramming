using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.FebProgramming
{
    public class Singleton
    {
        static Singleton instance;
        public string setting { get; set; } = "color blue";

        protected Singleton() 
        {
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance= new Singleton();
            }
            return instance;
        }
    }
}
