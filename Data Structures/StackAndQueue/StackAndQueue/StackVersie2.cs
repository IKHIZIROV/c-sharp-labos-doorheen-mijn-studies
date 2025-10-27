using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackVersie2
    {
        private int[] _numbers = new int[10];
        private int _top = 0;

        public void Push(int number)
        {
            if (IsFull() == false)
            {
                _numbers[_top] = number;
                _top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty() == false)
            {
                _top--;
                return _numbers[_top];
            }
            else
                return 0;
        }

        public bool IsEmpty()
        {
            if (_numbers.Length == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsFull()
        {
            if (_numbers.Length == 10)
            {
                return true;
            }
            else
                return false;
        }
    }
}

