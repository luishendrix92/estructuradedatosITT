using System;
using System.Collections;

class Pila {
  string[] datos;
  int posicion = 0, tope;
  
  public Pila(int maxDatos) {
    tope = maxDatos;
    datos = new string[maxDatos];
  }
  
  public void Push(string dato) {
    if (posicion == tope) {
      Console.WriteLine("La pila ya está llena.");
    } else {
      datos[posicion] = dato;
      posicion++;
    }
  }
  
  public string Pop() {
    if (posicion <= 0) {
      Console.WriteLine("La pila está vacía.");
      return null;
    } else {
      posicion--;
      return datos[posicion];
    }
  }
}

class Programa {
  static void Main() {
    Console.WriteLine("De qué tamaño quieres la pila?");
    int tamaño = Int32.Parse(Console.ReadLine());
    Pila pila = new Pila(tamaño);
    
    for (int i = 0; i < tamaño; i++) {
      Console.Write("Inserta el dato #{0}: ", i + 1);
      pila.Push(Console.ReadLine());
    }
    
    Console.WriteLine("\nÉstos son los datos insertados");
    
    for (int i = 0; i < tamaño; i++) {
      Console.WriteLine(pila.Pop());
    }
  }
}