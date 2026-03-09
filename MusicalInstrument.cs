using System;

namespace Lab1.Classes
{
    abstract class MusicalInstrument
    {
        protected string Name; 
        protected string Characteristics; 

        public MusicalInstrument() 
        { 
            Name = "Невідомий інструмент"; 
            Characteristics = "Без характеристик"; 
        }

        public MusicalInstrument(string name) 
        { 
            Name = name; 
            Characteristics = "Без характеристик"; 
        }

        public MusicalInstrument(string name, string characteristics) 
        { 
            Name = name; 
            Characteristics = characteristics; 
        }
        
        public MusicalInstrument(MusicalInstrument other) 
        { 
            Name = other.Name; 
            Characteristics = other.Characteristics; 
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

        public void SetName(string name) => Name = name;
        public string GetName() => Name;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Характеристики: {Characteristics}");
        }
    }
}
