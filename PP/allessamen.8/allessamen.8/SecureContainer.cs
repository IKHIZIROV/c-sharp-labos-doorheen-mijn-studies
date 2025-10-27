using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allessamen._8
{
    class SecureContainer : Container, ISafe
    {
        public SecureContainer(int id) : base(id)
        {
        }
        public void GeefAantalLeesAttempts()
        {
            Console.WriteLine(kerenUitgelezen);
        }
        public void VerzegelInhoud()
        {
            verzegeld = true;
        }
        private bool verzegeld = false;
        private int kerenUitgelezen = 0;
        public override int KostPrijs
        {
            get { kerenUitgelezen++;
                return 0;
            }
        }
    }
}
