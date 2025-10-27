using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography;


namespace oefn_encryptie_en_decryptie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToEncrypt = "farooq is cute en taner is gay";

            Console.WriteLine("Dit is je bericht om te encrypten:");
            Console.WriteLine(stringToEncrypt);

            X509Certificate2 cert = LoadCertificateFromStore();

            X509Certificate2 recipientCert = new X509Certificate2(cert);

            byte[] encrypted = EncryptWithCms(stringToEncrypt, recipientCert);

            Console.WriteLine("Encrypted bericht (Base64):");
            Console.WriteLine(Convert.ToBase64String(encrypted));

            string decrypted = DecryptWithCms(encrypted, recipientCert);

            Console.WriteLine("Decrypted bericht:");
            Console.WriteLine(decrypted);
        }

        public static byte[] EncryptWithCms(string plainText, X509Certificate2 recipientCert)
        {
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);

            ContentInfo contentInfo = new ContentInfo(dataToEncrypt);
            EnvelopedCms cms = new EnvelopedCms(contentInfo);
            CmsRecipient recipient = new CmsRecipient(
                SubjectIdentifierType.IssuerAndSerialNumber,
                recipientCert);

            cms.Encrypt(recipient);
            return cms.Encode();
        }


        public static string DecryptWithCms(byte[] encryptedData, X509Certificate2 certWithPrivateKey)
        {
            EnvelopedCms cms = new EnvelopedCms();
            cms.Decode(encryptedData);
            cms.Decrypt(new X509Certificate2Collection(certWithPrivateKey));
            return Encoding.UTF8.GetString(cms.ContentInfo.Content);
        }

        // Dummy: laad cert uit store (voor demo)
        public static X509Certificate2 LoadCertificateFromStore()
        {
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            // Neem EERSTE cert met private key (voor demo) — in praktijk betere filter!
            foreach (var cert in store.Certificates)
            {
                if (cert.HasPrivateKey)
                {
                    store.Close();
                    return cert;
                }   
            }
            store.Close();
            throw new Exception("Geen geschikt certificaat gevonden.");
        }
    }
}
