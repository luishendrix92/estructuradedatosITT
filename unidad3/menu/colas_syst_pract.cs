using System;
using System.Collections;

namespace Unidad3 {
  class Practica7 {
   public static void Mostrar() {
      Queue cola = new Queue();
      
      Console.Clear();
      Console.Write("Cuántos datos quieres meter?: ");
      MeterDatos(cola, Int32.Parse(Console.ReadLine()));
      
      Console.WriteLine("Elementos en cola: {0}", cola.Count);
      ImprimirCola(cola);   
      
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey(); 
    }
    
    static void MeterDatos(Queue cola, int num) {
      for (int i = 0; i < num; i++) {
        Console.Write("Dame el dato #{0}: ", i + 1);
        cola.Enqueue(Console.ReadLine());
      }
      
      Console.WriteLine("{0} datos introducidos con éxito!\n", num);
    }
    
    static void ImprimirCola(Queue cola) {
      int cantidad = cola.Count;
      
      for (int i = 0; i < cantidad; i++) {
        Console.WriteLine("Total de elementos: {0}", cola.Count);
        Console.WriteLine("Elemento retirado: {0}", cola.Dequeue());
      }
      
      Console.WriteLine("\nElementos restantes de la cola: {0}",
        cola.Count);
    }
  }
}