using System;

namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Skriv j för ja och n för nej.");
            char gymn = char.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Vad är din ålder i hela år?");
            byte ålder = byte.Parse(Console.ReadLine());

            if (gymn == 'j' && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}