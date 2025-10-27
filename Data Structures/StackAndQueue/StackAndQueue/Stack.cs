using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        private int[] _numbers = new int[10];
        private int _top = 0;

        public void Push(int number)
        {
            _numbers[_top] = number;
            _top++;
        }

        public int Pop()
        {
            _top--;
            return _numbers[_top];
        }
    }
}
