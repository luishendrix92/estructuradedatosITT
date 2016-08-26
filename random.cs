using System;

class Programa {
  static void Main(string[] args) {
    // Limpiar Pantalla
    Console.Clear();
    ///////////////////
    int[] numeros = new int[10];
    Random rand = new Random();
    int numRandom;
    
    for (int i = 0; i < 10; i++) {
      do { // Genera número entre 1 y 10 que no esté en el arreglo
      	// El 11 nunca será tomado en cuenta
      	numRandom = rand.Next(1, 11);
      } while (Array.IndexOf(numeros, numRandom) >= 0);
      
      numeros[i] = numRandom;
    } // Fin de llenar cada index del arreglo del 0 al 9 (1 a 10)
    
    // Imprimir el arreglo de números en pantalla
    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Número del arreglo en Index [{0}]: {1}.", i, numeros[i]);
    } // Fin de imprimir cada item en el arreglo
  } // Fin de Método Main
} // Fin de clase Programa