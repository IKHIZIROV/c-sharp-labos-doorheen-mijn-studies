using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetlat
{
    class Meetlat
    {
        private double lengte = 0.0;
        public double BeginLengte
        {
            set
            {
                lengte = value;
            }
        }

        public double Meter
        {
            get
            {
                return lengte;
            }
        }

        public double Cm
        {
            get
            {
                return lengte*100.0;
            }
        }

        public double Km
        {
            get
            {
                return lengte/1000.0;
            }
        }

        public double Voet
        {
            get
            {
                return lengte*3.2808;
            }
        }
    }
}
