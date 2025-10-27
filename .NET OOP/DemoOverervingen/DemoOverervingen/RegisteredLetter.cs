using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverervingen
{
    class RegisteredLetter
    {
		private double distance;

		public double Distance
		{
			get { return distance; }
			set { if (value > 0) distance = value; }
		}

		public virtual byte Duration
		{
			get { return Convert.ToByte(Math.Ceiling(Distance) / 100); }
		}

		private double price;

		public virtual double Price
		{
			get 
			{
				double price = 15;
				double amountExtra = Distance / 100;
				if (amountExtra > 0)
				{
					price += amountExtra * 10;
				}
				return price; 
			}
		}
	}
}
