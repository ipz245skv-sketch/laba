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

    class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий мідний інструмент") { }
        public override void Sound() => Console.WriteLine("Тромбон видає гучний, насичений звук.");
        public override void Show() => Console.WriteLine("Назва: Тромбон");
        public override void Desc() => Console.WriteLine("Має висувну кулісу для зміни висоти звуку.");
        public override void History() => Console.WriteLine("З'явився в XV столітті, походить від труби.");
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Чотириструнний гавайський інструмент") { }
        public override void Sound() => Console.WriteLine("Укулеле звучить легко і весело.");
        public override void Show() => Console.WriteLine("Назва: Укулеле");
        public override void Desc() => Console.WriteLine("Маленький інструмент, схожий на гітару.");
        public override void History() => Console.WriteLine("З'явився на Гаваях у ХІХ столітті.");
    }

    class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Великий смичковий інструмент") { }
        public override void Sound() => Console.WriteLine("Віолончель звучить глибоко і насичено.");
        public override void Show() => Console.WriteLine("Назва: Віолончель");
        public override void Desc() => Console.WriteLine("Смичковий інструмент з чотирма струнами, грають сидячи.");
        public override void History() => Console.WriteLine("Розвинулась із басових скрипок у XVI ст.");
    }
}