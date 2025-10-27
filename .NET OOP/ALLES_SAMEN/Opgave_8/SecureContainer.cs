using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    class SecureContainer : Container, ISafe
    {
        public SecureContainer(int id) : base(id)
        {
        }

        public int GeefAantalLeesAttempts()
        {
            return leesAttempts;
        }

        public void VerzegelInhoud()
        {
            isVerzegeld = true;
        }

        private int leesAttempts = 0;

        private bool isVerzegeld = false;

        public override int KostPrijs
        {
            get
            {
                leesAttempts++;
                if (isVerzegeld) return 0;
                return base.KostPrijs;              // return kostprijs van container
            }
        }

        public void 
    }
}
