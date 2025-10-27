using System;
using System.IO;
using System.Security.Cryptography;

namespace DigitaleHandtekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "secret.txt";
            string pubKeyPath = "secret.txt.pubkey";
            string sigPath = "secret.txt.sig";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Farooq is cute");
                Console.WriteLine("Bestand 'secret.txt' aangemaakt.");
            }

            string base64Hash;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] hashBytes = sha256.ComputeHash(fileBytes);
                base64Hash = Convert.ToBase64String(hashBytes);
            }

            Console.WriteLine($"Je hash is: {base64Hash}");

            string keyId = "KEY-1";
            File.WriteAllText(pubKeyPath, keyId);

            string signature = $"{keyId}:{base64Hash}";
            File.WriteAllText(sigPath, signature);

            Console.WriteLine("Bestanden 'secret.txt.pubkey' en 'secret.txt.sig' aangemaakt!");
        }
    }
}
