using System;

public class ArbolBinario {
  class Nodo {
    public int dato;
    public Nodo izquierdo, derecho;
  }
  
  Nodo raiz;
  
  public ArbolBinario() { raiz = null; }
  
  public void Insertar(int _dato) {
    Nodo nuevo;
    nuevo = new Nodo();
    nuevo.dato = _dato;
    nuevo.izquierdo = null;
    nuevo.derecho = null;
    
    if (raiz == null) {
      raiz = nuevo;
    } else {
      Nodo anterior = null;
      Nodo recorrer = raiz;
      
      while (recorrer != null) {
        anterior = recorrer;
        
        if (_dato < recorrer.dato) {
          recorrer = recorrer.izquierdo;
        } else {
          recorrer = recorrer.derecho;
        }
      }
      
      if (_dato < anterior.dato) {
        anterior.izquierdo = nuevo;
      } else {
        anterior.derecho = nuevo;
      }
    }
  }
  
  private void ImprimirPreOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      Console.Write("{0} --> ", _recorrer.dato);
      
      ImprimirPreOrden(_recorrer.izquierdo);
      ImprimirPreOrden(_recorrer.derecho);
    }
  }
  
  public void ImprimirPreOrden() {
    ImprimirPreOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
  
  private void ImprimirInOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      ImprimirInOrden(_recorrer.izquierdo);
      Console.Write("{0} --> ", _recorrer.dato);
      ImprimirInOrden(_recorrer.derecho);
    }
  }
  
  public void ImprimirInOrden() {
    ImprimirInOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
  
  private void ImprimirPostOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      ImprimirPostOrden(_recorrer.izquierdo);
      ImprimirPostOrden(_recorrer.derecho);
      Console.Write("{0} --> ", _recorrer.dato);
    }
  }
  
  public void ImprimirPostOrden() {
    ImprimirPostOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
}

public class Programa {
  public static void Main(string[] args) {
    ArbolBinario arbol = new ArbolBinario();
    
    arbol.Insertar(100);
    arbol.Insertar(50);
    arbol.Insertar(45);
    arbol.Insertar(102);
    arbol.Insertar(25);
    arbol.Insertar(101);
    arbol.Insertar(75);
    arbol.Insertar(150);
    
    Console.WriteLine("Impresión pre-orden: ");
    arbol.ImprimirPreOrden();
    Console.WriteLine("Impresión entre-orden: ");
    arbol.ImprimirInOrden();
    Console.WriteLine("Impresión post-orden: ");
    arbol.ImprimirPostOrden();
  }
}