using System;
using System.Collections;

namespace Unidad3 {
  class Practica2 {
    public static void Mostrar() {
      Stack pila = new Stack();
      string datoLeido, datoNuevo;
      int tamaño;
      
      Console.Clear();
      Console.Write("Tamaño de la pila: ");
      tamaño = Int32.Parse(Console.ReadLine());
      
      // Escribiendo nuevos datos en la pila
      for (int i = 0; i < tamaño; i++) {
        Console.Write("Integra la palabra o frase: ");
        datoNuevo = Console.ReadLine();
        pila.Push(datoNuevo);
      }
      
      Console.WriteLine("--------------------------");
      
      // Leyendo datos de la pila y vaciándola
      for (int i = 0; i < tamaño; i++) {
        datoLeido = (string) pila.Pop();
        Console.WriteLine(datoLeido);
      }
      
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey();
    }
  }
}