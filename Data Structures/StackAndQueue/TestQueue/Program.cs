using StackAndQueue;

namespace TestQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            StackVersie2 stack = new StackVersie2();

            Console.WriteLine("Hallo, geef 5 getallen!");

            for (int i = 0; i < 15; i++)
            {
                if (stack.IsFull() == false)
                {
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    queue.Enqueue(number);
                    stack.Push(number);
                }
            }

            int output;
            int outputStack;

            for (int i = 0; i < 15; i++)
            {
                output = queue.Dequeue();
                outputStack = stack.Pop();
                Console.WriteLine($"Getal {i+1} => Queue: {output}, Stack: {outputStack}");
                Console.WriteLine("");
            }
        }
    }
}