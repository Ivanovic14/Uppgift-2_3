using System;
namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jasså, hej! Det verkar som att du vill hyra en bil!");
            Console.WriteLine("Jag förstår, vi ska se hur jag kan hjälpa dig nu då");
            Console.WriteLine("Hur länge vill du hyra bilen? I dagar");
            string input = Console.ReadLine();
            int dagar = int.Parse(input);
            int sum = (dagar * 500) - 500; 
            Console.WriteLine("Okej, det verkar alltså som att du vill hyra bilen i " + dagar + " dagar. Det kommer då att kosta dig " + sum + " kronor totalt.");
            Console.WriteLine("Okej, hur långt vill du köra då, i kilometer? Svara med siffror");
            string input2 = Console.ReadLine();
            int avstånd = int.Parse(input2);
            int sum2 = (avstånd * 1);
            Console.WriteLine("Okej, du vill alltså köra " + avstånd + " kilometer.");

            Console.WriteLine("Det totala beloppet för att hyra vår bil, i " + dagar + " dagar + att köra " + avstånd + " kilometer, kommer alltså att kosta dig:");
            Console.WriteLine(sum + avstånd + 300 + " kronor totalt");
            Console.WriteLine("Det blir " + sum + " kronor för hur många dagar du hyr i + priset i avstånd, som är " + sum2 + " kronor.");
                Console.Write("Sist men inte minst blir det ytterligare 300kr som startavgift.");
                Console.WriteLine("Totalt blir allt:" + sum + sum2 + 300 + " kronor.");
        }
    }
}