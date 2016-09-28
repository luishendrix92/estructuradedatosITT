using System;
using System.Collections;

class Programa {
  static void Main() {
    Queue cola = new Queue();
    
    cola.Enqueue("Salón 1");
    cola.Enqueue("Salón 2");
    cola.Enqueue("Salón 3");
    cola.Enqueue("Salón 4");
    cola.Enqueue("Salón 5");
    cola.Enqueue("Salón 6");
    
    int cantidad = cola.Count;
    
    Console.WriteLine("Elementos en cola: {0}\n", cantidad);
    
    for (int i = 0; i < cantidad; i++) {
      Console.WriteLine("Total de elementos: {0}", cola.Count);
      Console.WriteLine("Elemento retirado: {0}", cola.Dequeue());
    }
    
    Console.WriteLine("\n\nElementos restantes de la cola: {0}",
      cola.Count);
  }
}