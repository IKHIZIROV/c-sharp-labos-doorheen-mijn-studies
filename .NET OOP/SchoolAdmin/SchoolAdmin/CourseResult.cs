using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    class CourseResult
    {

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        private byte result;

        public CourseResult(string name, byte result)
        {
            Name = name;
            Result = result;
        }

        public byte Result
        {
            get
            {
                return result;
            }
            set
            {
                if (!(value > 20))
                {
                    result = value;
                }
            }
        }

    }
}
