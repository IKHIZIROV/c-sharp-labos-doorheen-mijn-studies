using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11
{
    class DagboekEntry
    {
        public bool IsInspired { get; set; }

        private bool isPrivate = false;

        public bool IsPrivate
        {
            get { return isPrivate;}
            private set { isPrivate = value;}
        }

        private string description;

        public string Description
        {
            get
            {
                if (IsPrivate = !true)
                    return description;
                else
                    return "***PRIVATE***";
            }
            set { description = value; }
        }

        private int qal;

        public int Qal
        {
            get { return qal; }
            set
            {
                if (value < 0)
                    qal = 0;
                else if (value > 100)
                    qal = 100;
                else
                    qal = value;
            }
        }

        public void MakePrivate(bool yn)
        {
            IsPrivate = yn;
        }

        public void ResetEntry()
        {
            IsPrivate = false;
            IsInspired = false;
            Qal = 50;
            Description = "";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"********\nENTRY:\n{Description}\nQal= {Qal}\n*********");
        }

        public DagboekEntry()
        {
            ResetEntry();
        }

        public DagboekEntry(int qalx, bool isinspiredx, string descriptionx, bool isprivatex)
        {
            Qal = qalx;
            IsInspired = isinspiredx;
            Description = descriptionx;
            IsPrivate = isprivatex;
        }


    }
}
