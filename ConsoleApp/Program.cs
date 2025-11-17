
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test klase Proizvod
            Proizvod proizvod = new Proizvod("Laptop", 7500.50m, 10);
            proizvod.IspisiInformacije();

            Console.WriteLine("\n--- Nasljeđivanje ---\n");

            // Test klase PametniTelefon
            PametniTelefon telefon = new PametniTelefon("iPhone 15", "Apple", 2025, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            Console.ReadLine();
        }
    }
}
