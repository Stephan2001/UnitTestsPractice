using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public abstract class Burger
    {
        private string patty = "Beef";
        private string bun = "Plain Wheat";
        public virtual string getPatty()
        {
            return patty;
        }

        public string getBun(){
            return bun;
        }
        public string getBun(string option1)
        {
            return option1;
        }
        public string getBun(string option1, string potion2)
        {
            return option1 + potion2;
        }
    }
}
