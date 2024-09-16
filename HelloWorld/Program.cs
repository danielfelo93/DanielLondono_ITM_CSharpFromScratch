using System.Runtime.CompilerServices;

namespace HelloWorld
{

    class Program
    {
        static void Main()
        {
            const string NameExample = "Daniel";
            Console.WriteLine($"HelloWorld! {NameExample}");
            Console.WriteLine($"Thanks for coming {NameExample}");

            /* Data Type */
            int myNum = 5;
            double mydouybleNum = 5.990;
            char muLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            
            Console.WriteLine("¡Hola, Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput= Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput= Console.ReadLine();
            bool isDateValid=DateOnly.TryParse(birthdayInput, out dateConverted);
            if(isDateValid==false) Console.WriteLine(
                $"La fecha de nacimiento es invalida. Este dato es erroneo {birthdayInput}");
            var person = new Person{
                Name=nameInput,
                Birthday=dateConverted,
                Age= DateTime.Now.Year-dateConverted.Year
            };
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad: {person.Age} años");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}