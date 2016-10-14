using System;

namespace Unidad3 {
  public class _Nodo {
    public int dato;
    public _Nodo siguiente;
  }

  public class Cola {
    public _Nodo COLA_ULTIMO, COLA_PRIMERO;

    public void Insertar(int dato) {
      _Nodo P     = new _Nodo();
      P.dato      = dato;
      P.siguiente = null;

      if (COLA_ULTIMO != null) {
        COLA_ULTIMO.siguiente = P;
      }

      if (COLA_PRIMERO == null) {
        COLA_PRIMERO = P;
      }

      COLA_ULTIMO = P;
    }

    public int Leer() {
      _Nodo P = COLA_PRIMERO;
      int dato;

      if (P != null) {
        dato = P.dato;
        COLA_PRIMERO = P.siguiente;
      } else {
        COLA_PRIMERO = null;
        COLA_ULTIMO  = null;
        dato         = -1;
      }

      return dato;
    }
  }

  class Practica6 {
    public static void Mostrar() {
      Cola c = new Cola();
      int dato;
      int numero;

      Console.Clear();
      Console.WriteLine("Guardando información en cola");
      c.COLA_PRIMERO = null;
      c.COLA_ULTIMO  = null;

      for (int i = 0; i < 10; i++) {
        Console.Write("Agrega el número: ");
        numero = int.Parse(Console.ReadLine());
        c.Insertar(numero);
      }

      Console.WriteLine("Leyendo información de cola");
      dato = c.Leer();

      while (dato >= 0) {
        Console.WriteLine(dato);
        dato = c.Leer();
      }

      Console.WriteLine("Cola vacía");
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey();
    }
  }
}