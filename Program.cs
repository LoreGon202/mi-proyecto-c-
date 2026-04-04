using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted;
            string nameInput;
            string birthdayInput;

            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.Write("Escribe tu nombre: ");
            nameInput = Console.ReadLine() ?? "";

            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.Write("Escribe tu fecha de nacimiento en formato dd/mm/yyyy: ");
            birthdayInput = Console.ReadLine() ?? "";

            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);

            if (!isDateValid)
            {
                Console.WriteLine($"La fecha de nacimiento es inválida: {birthdayInput}");
                return;
            }

            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad es {person.Age} años");

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; } = "";
        public DateOnly Birthday { get; set; }
        public int Age { get; set; }
    }
}