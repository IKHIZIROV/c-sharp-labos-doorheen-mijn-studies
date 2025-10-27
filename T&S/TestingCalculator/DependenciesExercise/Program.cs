namespace DependenciesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //'normale' manier van foreach
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //herschreven met lambda notatie
            numbers.ForEach(x => Console.WriteLine(x));
            numbers.ForEach(number => Console.WriteLine(number));
        }
    }
}
