using System;

namespace Unidad3 {
  class ColaArr {
    int[] arreglo;
    int principio, fin, tam;

    public ColaArr() {
      arreglo = new int[5];
      principio = fin = -1;
      tam = 5;
    }

    public bool Llena() {
      return (fin >= tam - 1)? true : false;
    }
    
    public bool Vacia() {
      return (principio == -1)? true : false;
    }
    
    public bool Enqueue(int dato) {
      if (!Llena()) {
        arreglo[++fin] = dato;
        
        if (fin == 0) principio = 0;
        return true;
      } else {
        return false;
      }
    }
    
    public bool Dequeue(ref int dato) {
      if (!Vacia()) {
        dato = arreglo[principio];
        
        if (principio == fin) {
          principio = -1;
          fin = principio;
        } else {
          principio++;
        }
        
        return true;
      } else {
        return false;
      }
    }
  }

  class Practica8 {
    public static void Mostrar() {
      ColaArr cola = new ColaArr();
      int i, d = 0;
      
      Console.Clear();
      Console.WriteLine("Agregando registros:");
      
      for (i = 0; i < 5; i++) {
        if (cola.Enqueue(i + 1)) {
          Console.WriteLine("Dato agregado: {0}", i + 1);
        } else {
          Console.WriteLine("Cola llena!");
        }
      }
      
      Console.WriteLine("Extrayendo los registros:");
      
      while (true) {
        if (cola.Dequeue(ref d)) {
          Console.WriteLine("Registro extraído: {0}", d);
        } else {
          Console.WriteLine("Cola vacía!");
          break;
        }
      }
      
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey();
    }
  }
}