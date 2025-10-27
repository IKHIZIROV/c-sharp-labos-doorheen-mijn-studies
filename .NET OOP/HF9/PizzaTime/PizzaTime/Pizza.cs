using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizza
    {
        private string toppings = "peperoni, kaas en tomaten";
        public string Toppings
        {
            get { return toppings; }
            set { if (value != "") toppings = value; }
        }
        private int diameter = 30; // cm
        public int Diameter
        {
            get { return diameter; }
            set { if (value > 0) diameter = value; }
        }
        private double prijs = 7; // euro
        public double Prijs
        {
            get { return prijs; }
            set { if (value > 0) prijs = value; }
        }


    }
}
