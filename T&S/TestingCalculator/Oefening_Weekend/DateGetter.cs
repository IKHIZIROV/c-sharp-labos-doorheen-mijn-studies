using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Weekend
{
    public class DateGetter : IDateGetter
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
