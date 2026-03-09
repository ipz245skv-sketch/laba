using System;

namespace Lab1.Classes
{
    abstract class MusicalInstrument
    {
        protected string Name; 
        protected string Characteristics; 

        // Конструктор за замовчуванням
        public MusicalInstrument() 
        { 
            Name = "Невідомий інструмент"; 
            Characteristics = "Без характеристик"; 
        }

        // Конструктори з параметрами
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

        // Конструктор копіювання
        public MusicalInstrument(MusicalInstrument other) 
        { 
            Name = other.Name; 
            Characteristics = other.Characteristics; 
        }

        // Абстрактні методи (мають бути реалізовані в нащадках)
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

        // Методи встановлення та читання
        public void SetName(string name) => Name = name;
        public string GetName() => Name;

        // Метод виводу всієї інформації
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Характеристики: {Characteristics}");
        }
    }
}