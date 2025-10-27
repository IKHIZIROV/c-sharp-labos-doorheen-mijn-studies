using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentklasse
{
    public enum Klassen { TI1, TI2, TI3 }
    public class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }
        public void BerekenGemiddelde()
        {
            double gemiddelde = ((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0);
            Console.WriteLine($"Je gemiddelde is: {gemiddelde}");
        }
        public void GeefOverzicht()
        {
            Console.WriteLine($"Naam: {Naam} Klas: {Klas}");
            Console.WriteLine($"Leeftijd: {Leeftijd}");
            Console.WriteLine("");
            Console.WriteLine("Je resultaten:");
            Console.WriteLine("**************");
            Console.WriteLine($"Communicatatie: {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology: {PuntenWebTech}");
            BerekenGemiddelde();
        }
    }
}
