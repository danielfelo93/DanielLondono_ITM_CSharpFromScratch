﻿namespace itm.csharp.basic {
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine($"¡Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú: ");
        Menu.MostrarMenu();
        while(true){

            string entrada = Console.ReadLine().ToLower();
            if(entrada == "q" || entrada == "exit") {
                breack; //Salir del bucle
            }

            if(int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 15) {
                //logica del switch

                Console.WriteLine("Peresiona una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu.MostrarMenu();
            }
            else {
                Console.WriteLine("Opción no valida. Por favor, ingrese un numero entre 1 y 15, o 'q' o 'exit' para salir.");

            }
        
        }
    Console.WriteLine("¡Hasta luego!");
    }
}
}

