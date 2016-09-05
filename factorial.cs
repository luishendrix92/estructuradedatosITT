using System;

class Program {
    static int fact(int n) { return n < 2? 1 : n * fact(n - 1); }

    static int factorial(int numero) {
        int resultado = 1;

        for (int i = 2; i <= numero; i++) {
            resultado *= i;
        }

        return resultado;
    }

    static void Main(string[] args) {
        int numero = 6;

        Console.WriteLine("El factorial de {0} es {1}.",
            numero, fact(numero));
        Console.WriteLine("El factorial de {0} es {1}.",
            numero, factorial(numero));

        Console.ReadKey();
    }
}
