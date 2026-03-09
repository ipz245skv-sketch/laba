using System;
using Lab1.Classes;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };

            foreach (var instrument in instruments)
            {
                Console.WriteLine(new string('-', 30));
                instrument.ShowInfo();
                instrument.Sound();
                instrument.Show();
                instrument.Desc();
                instrument.History();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
