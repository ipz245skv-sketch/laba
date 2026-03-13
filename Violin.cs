using System;

namespace Lab1.Classes
{
    class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Смичковий струнний інструмент") { }
        public override void Sound() => Console.WriteLine("Скрипка звучить ніжно і мелодійно.");
        public override void Show() => Console.WriteLine("Назва: Скрипка");
        public override void Desc() => Console.WriteLine("Смичковий інструмент з чотирма струнами.");
        public override void History() => Console.WriteLine("Виникла в Італії у XVI столітті.");
    }
}