using System;

namespace Lab1.Classes
{
    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Чотириструнний гавайський інструмент") { }
        public override void Sound() => Console.WriteLine("Укулеле звучить легко і весело.");
        public override void Show() => Console.WriteLine("Назва: Укулеле");
        public override void Desc() => Console.WriteLine("Маленький інструмент, схожий на гітару.");
        public override void History() => Console.WriteLine("З'явився на Гаваях у ХІХ столітті.");
    }
}