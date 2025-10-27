using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H11_FoodPurchase
{
    class FoodPurchase
    {
		public FoodPurchase(string productName, byte number, double unitPrice, bool refrigerate)
		{
			this.productName = productName;
			Number = number;
			UnitPrice = unitPrice;
			Refrigerate = refrigerate;
			dateOfCreation = DateTime.Now;
		}

		public double CalculateTotalPrice()
		{
			return UnitPrice * number;
		}

        public bool Refrigerate;

		private string productName;

		public string ProductName
		{
			get { return productName.ToUpper(); }
		}

		private int number;

		public int Number
		{
			get { return number; }
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Ongeldig aantal");
				}
				else
				{
					number = Convert.ToInt32(value);
				}
			}
		}

		private double unitPrice;

		public double UnitPrice
		{
			get { return unitPrice; }
			set {
					if (value <= 0 || value > 5000)
                {
                    Console.WriteLine("Ongeldig eenheidsprijs");
                }
                else
                {
					unitPrice = value;
                }
            }
		}

		private DateTime dateOfCreation;

		public DateTime ExpirationDate
		{
			get { return dateOfCreation.AddMonths(2); }
		}

	}
}
