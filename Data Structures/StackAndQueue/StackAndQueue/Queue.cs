namespace StackAndQueue
{
    public class Queue
    {
        private int[] _numbers = new int[10];
        private int _rear = 0;
        public void Enqueue(int number)
        {
            _numbers[_rear] = number;
            _rear++;
        }

        public int Dequeue()
        {
            int output = _numbers[0];
            for (int i = 0; i < _rear; i++)
            {
                _numbers[i] = _numbers[i + 1];
            }
            _rear--;
            return output;
        }
    }
}