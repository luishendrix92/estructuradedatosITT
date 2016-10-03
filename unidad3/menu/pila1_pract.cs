using System;
using System.Collections.Generic;

namespace Unidad3 {
  class Nodo {
    public string dato;
    public Nodo siguiente;
  }

  class Pila {
    public Nodo pila;
    
    public void Push(string dato) {
      Nodo _pila = new Nodo();
      
      _pila.dato = dato;
      _pila.siguiente = pila;
      pila = _pila;
    }
    
    public string Pop() {
      string dato;
      Nodo _pila = pila;
      
      if (_pila == null) {
        return null;
      } else {
        dato = _pila.dato;
        pila = _pila.siguiente;
        return dato;
      }
    }
  }

  class Practica1 {
    public static void Mostrar() {
      Pila pila = new Pila();
      string nuevoDato, datoLeido;
      bool pilaVacia;
      
      // Escribiendo datos en la pila
      Console.Clear();
      Console.WriteLine("Escribe 5 entradas en la pila:");
      
      for (int i = 0; i < 5; i++) {
        nuevoDato = Console.ReadLine();
        pila.Push(nuevoDato);
      }
      
      Console.WriteLine("Pila llenada con éxito!");
      
      // Leyendo datos de la pila
      Console.WriteLine("\nÉstos son los contenidos de la pila:");
      
      do {
        datoLeido = pila.Pop();
        pilaVacia = datoLeido == null;
        
        Console.WriteLine(pilaVacia? "Pila vacía" : datoLeido);
      } while (!pilaVacia);
      
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey();
    }
  }
}