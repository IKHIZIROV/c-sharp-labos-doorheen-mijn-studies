namespace zahma_oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10];
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(1, 100);
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("Welk getal moet verwijderd worden?");
            int todel = Convert.ToInt32(Console.ReadLine());

            int index = -1;
            bool found = false;
            for (int i = 0; i < ar.Length; i++)
            {
                if (!found && ar[i] == todel)
                {
                    found = true;
                    index = i;
                }
            }


            if (found)
            {
                for (int i = index; i < ar.Length - 1; i++)
                {
                    ar[i] = ar[i + 1];
                }
                ar[ar.Length - 1] = -1; 
            }

      
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
        }
    }