using System.Collections;
using System;

namespace Unidad3 {
  class Menu {
    static void Main(string[] args) {      
      while (true) {
        Console.Clear();
        
        Console.WriteLine("Unidad 3 - Pilas y Colas:");
        Console.WriteLine("Escribe 0 y [ENTER] para salir del programa!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("\nPrograma 1: Pilas con nodos");
        Console.WriteLine("Programa 2: Pilas con librería del sistema");
        Console.WriteLine("Programa 3: Pilas con arreglos: n cantidad");
        Console.WriteLine("Programa 4: Pilas con arreglos: doble");
        Console.WriteLine("Programa 5: Pilas con arreglos: búsqueda");
        Console.WriteLine("Programa 6: Colas con nodos");
        Console.WriteLine("Programa 7: Colas con librería del sistema");
        Console.WriteLine("Programa 8: Colas con arreglos");
        
        int opc = CapturarOpcion(0, 8);
        if (opc == 0) break; // Salir del programa si opc es 0
        
        switch (opc) {
          case 1: Practica1.Mostrar(); break;
          case 2: Practica2.Mostrar(); break;
          case 3: Practica3.Mostrar(); break;
          case 4: Practica4.Mostrar(); break;
          case 5: Practica5.Mostrar(); break;
          case 6: Practica6.Mostrar(); break;
          case 7: Practica7.Mostrar(); break;
          case 8: Practica8.Mostrar(); break;
        }
      }
      
      Console.Clear();
    }
    
    static int CapturarOpcion(int a, int b) {
      int opcion;
      
      Console.Write("\nEscribe el número de opción: ");
      
      do {
        try {
          opcion = Int32.Parse(Console.ReadLine());
        } catch {
          Console.WriteLine("ERROR: No escribas letras!");
          opcion = 9;
        }
      } while (!EnRango(opcion, 0, 8));
      
      return opcion;
    }
    
    static bool EnRango(int num, int a, int b) {
      return num >= a && num <= b;
    }
  }
}