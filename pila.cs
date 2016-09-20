using System;

class Nodo {
  public int dato;
  public Nodo siguiente;
}

class Pila {
  public Nodo pila;
  
  public void Push(int dato) {
    Nodo _pila = new Nodo();
    
    _pila.dato = dato;
    _pila.siguiente = pila;
    pila = _pila;
  }
  
  public int Pop() {
    int dato;
    Nodo _pila = pila;
    
    if (_pila == null) {
      return -1;
    } else {
      dato = _pila.dato;
      pila = _pila.siguiente;
      return dato;
    }
  }
}

class Programa {
  static void Main() {
    Pila miPila = new Pila();
    int dato;
    
    Console.WriteLine("Guardando Información en Pila");
    miPila.pila = null; // Asegurarse que esté vacía
    
    for (int i = 0; i < 10; i++) {
      miPila.Push(i);
    }
    
    Console.WriteLine("Leyendo información de la pila");
    
    do {
      dato = miPila.Pop();
      Console.WriteLine(dato);
    } while (dato > 0);
    
    Console.WriteLine("La pila ya se vacío");
    Console.ReadKey();
  }
}