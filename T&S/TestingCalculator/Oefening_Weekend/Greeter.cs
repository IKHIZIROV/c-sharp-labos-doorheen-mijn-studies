using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Weekend
{
    public class Greeter
    {
        private IDateGetter dateGetter;

        public Greeter(IDateGetter dateGetter)
        {
            this.dateGetter = dateGetter;
        }

        public string GetMessage()
        {
            DateTime date = dateGetter.GetDate();
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Party time...  it's the weekend!";
            }
            return "Work hard, the weekend is on it's way...";
        }
    }
}
