using System;

class Program {
    static void Main(string[] args) {
        // Solicitar valor inicial y final al usuario
        Console.Write("Ingrese valor inicial: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.Write("Ingrese valor final: ");
        int fin = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares entre {0} y {1}:", inicio, fin);

        // Iniciar puntero en el valor inicial y avanzar de dos en dos hasta el valor final
        int i = inicio;
        while (i <= fin) {
            if (i % 2 == 0) {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}

