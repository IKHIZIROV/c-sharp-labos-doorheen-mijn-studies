namespace rekenmachine
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operator (+, -, *, /):");
                char op = Convert.ToChar(Console.ReadLine());

                int result;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        return;
                }

                Console.WriteLine("Result: {0}", result);
            }
        }
    }