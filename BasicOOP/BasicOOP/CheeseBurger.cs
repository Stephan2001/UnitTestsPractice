using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    public class CheeseBurger : Burger
    {
        public string Cheese = "Cheese";

        public String getCheese()
        {
            return Cheese;
        }
        public String AddCheddar()
        {
            this.Cheese = "Cheddar";
            return this.Cheese;
        }
    }
}
