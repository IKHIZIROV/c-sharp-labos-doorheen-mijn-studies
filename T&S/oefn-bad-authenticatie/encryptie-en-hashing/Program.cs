using System.Security.Cryptography;
using System.Text;

namespace encryptie_en_hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je wachtwoord om te hashen");

            string wachtwoord = HashString(Console.ReadLine());

            Console.WriteLine("Dit is de hash van je wachtwoord");
            Console.WriteLine(wachtwoord);
        }

        static public string HashString(string s = "")
        {
            string hash = "";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                hash = Convert.ToBase64String(bytes);
            }

            return hash;
        }
    }
}
