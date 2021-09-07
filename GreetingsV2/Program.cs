using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid

            Console.WriteLine("Mis su nimi on?");

            string UserName = Console.ReadLine();

            Console.WriteLine("Mis su perekonna nimi on?");

            string SurnName = Console.ReadLine();

            Console.WriteLine($"Hello, {UserName} {SurnName}");

            Console.Read();




        }
    }
}
