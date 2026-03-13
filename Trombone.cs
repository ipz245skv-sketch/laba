using System;

namespace Lab1.Classes
{
    class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий мідний інструмент") { }
        public override void Sound() => Console.WriteLine("Тромбон видає гучний, насичений звук.");
        public override void Show() => Console.WriteLine("Назва: Тромбон");
        public override void Desc() => Console.WriteLine("Має висувну кулісу для зміни висоти звуку.");
        public override void History() => Console.WriteLine("З'явився в XV столітті, походить від труби.");
    }
}