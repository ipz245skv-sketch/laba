using System;

namespace Lab1.Classes
{
    class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Великий смичковий інструмент") { }
        public override void Sound() => Console.WriteLine("Віолончель звучить глибоко і насичено.");
        public override void Show() => Console.WriteLine("Назва: Віолончель");
        public override void Desc() => Console.WriteLine("Смичковий інструмент з чотирма струнами, грають сидячи.");
        public override void History() => Console.WriteLine("Розвинулась із басових скрипок у XVI ст.");
    }
}