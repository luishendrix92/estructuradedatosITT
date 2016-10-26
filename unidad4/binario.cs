using System;

public class Nodo {
  public int dato;
  public Nodo izquierdo, derecho;
}

public class ArbolBinario {  
  private Nodo raiz = null;
  private int cantidad, altura;
  
  public void Insertar(int _dato) {
    if (!Existe(_dato)) {
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
  }
  
  public bool Existe(int _dato) {
    Nodo recorrer = raiz;
    
    while (recorrer != null) {
      if (_dato == recorrer.dato) {
        return true;
      } else {
        if (_dato > recorrer.dato) {
          recorrer = recorrer.derecho;
        } else {
          recorrer = recorrer.izquierdo;
        }
      }
    }
    
    return false;
  }
  
  private void ImprimirPreOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      Console.Write("{0} -> ", _recorrer.dato);
      
      ImprimirPreOrden(_recorrer.izquierdo);
      ImprimirPreOrden(_recorrer.derecho);
    }
  }
  
  public void ImprimirPreOrden() {
    ImprimirPreOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
  
  private void ImprimirPreOrdenConNivel(Nodo recorrer, int nivel) {
    if (recorrer != null) {
      Console.WriteLine("Dato {0}, Nivel {1}", recorrer.dato, nivel);
      ImprimirPreOrdenConNivel(recorrer.izquierdo, nivel + 1);
      ImprimirPreOrdenConNivel(recorrer.derecho, nivel + 1);
    }
  }
  
  public void ImprimirPreOrdenConNivel() {
    ImprimirPreOrdenConNivel(raiz, 0);
    Console.WriteLine();
  }
  
  private void ImprimirInOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      ImprimirInOrden(_recorrer.izquierdo);
      Console.Write("{0} -> ", _recorrer.dato);
      ImprimirInOrden(_recorrer.derecho);
    }
  }
  
  public void ImprimirInOrden() {
    ImprimirInOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
  
  private void ImprimirInOrdenConNivel(Nodo recorrer, int nivel) {
    if (recorrer != null) {
      ImprimirInOrdenConNivel(recorrer.izquierdo, nivel + 1);
      Console.WriteLine("Dato {0}, Nivel {1}", recorrer.dato, nivel);
      ImprimirInOrdenConNivel(recorrer.derecho, nivel + 1);
    }
  }
  
  public void ImprimirInOrdenConNivel() {
    ImprimirInOrdenConNivel(raiz, 0);
    Console.WriteLine();
  }
  
  private void ImprimirPostOrden(Nodo _recorrer) {
    if (_recorrer != null) {
      ImprimirPostOrden(_recorrer.izquierdo);
      ImprimirPostOrden(_recorrer.derecho);
      Console.Write("{0} -> ", _recorrer.dato);
    }
  }
  
  public void ImprimirPostOrden() {
    ImprimirPostOrden(raiz);
    Console.ReadKey();
    Console.WriteLine();
  }
  
  private void ImprimirPostOrdenConNivel(Nodo recorrer, int nivel) {
    if (recorrer != null) {
      ImprimirPostOrdenConNivel(recorrer.izquierdo, nivel + 1);
      ImprimirPostOrdenConNivel(recorrer.derecho, nivel + 1);
      Console.WriteLine("Dato {0}, Nivel {1}", recorrer.dato, nivel);
    }
  }
  
  public void ImprimirPostOrdenConNivel() {
    ImprimirPostOrdenConNivel(raiz, 0);
    Console.WriteLine();
  }
  
  private void Cantidad(Nodo recorrer) {
    if (recorrer != null) {
      cantidad++;
      Cantidad(recorrer.izquierdo);
      Cantidad(recorrer.derecho);
    }
  }
  
  public int Cantidad() {
    cantidad = 0;
    Cantidad(raiz);
    return cantidad;
  }
  
  private void CantidadHijos(Nodo recorrer) {
    if (recorrer != null) {
      if (recorrer.izquierdo == null && recorrer.derecho == null) {
        cantidad++;
      }
      
      CantidadHijos(recorrer.izquierdo);
      CantidadHijos(recorrer.derecho);
    }
  }
  
  public int CantidadHijos() {
    cantidad = 0;
    CantidadHijos(raiz);
    return cantidad;
  }
  
  private void Altura(Nodo recorrer, int nivel) {
    if (recorrer != null) {
      Altura(recorrer.izquierdo, nivel + 1);
      
      if (nivel > altura) {
        altura = nivel;
      }
      
      Altura(recorrer.derecho, nivel + 1);
    }
  }
  
  public int Altura() {
    altura = 0;
    Altura(raiz, 1);
    return altura;
  }
  
  public void NodoMayor() {
    if (raiz != null) {
      Nodo recorrer = raiz;
      
      while (recorrer.derecho != null) {
        recorrer = recorrer.derecho;
      }
      
      Console.WriteLine("Nodo Mayor del Árbol: {0}", recorrer.dato);
    }
  }
  
  public void NodoMenor() {
    if (raiz != null) {
      Nodo recorrer = raiz;
      
      while (recorrer.izquierdo != null) {
        recorrer = recorrer.izquierdo;
      }
      
      Console.WriteLine("Nodo Menor del Árbol: {0}", recorrer.dato);
    }
  }
  
  public void EliminarNodoMenor() {
    if (raiz != null) {
      if (raiz.izquierdo == null) {
        raiz = raiz.derecho;
      } else {
        Nodo atras = raiz;
        Nodo recorrer = raiz.izquierdo;
        
        while (recorrer.izquierdo != null) {
          atras = recorrer;
          recorrer = recorrer.izquierdo;
        }
        
        atras.izquierdo = recorrer.derecho;
      }
    }
  }
  
  public void EliminarNodoMayor() {
    if (raiz != null) {
      if (raiz.derecho == null) {
        raiz = raiz.izquierdo;
      } else {
        Nodo atras = raiz;
        Nodo recorrer = raiz.derecho;
        
        while (recorrer.derecho != null) {
          atras = recorrer;
          recorrer = recorrer.derecho;
        }
        
        atras.derecho = recorrer.izquierdo;
      }
    }
  }
}

public class Programa {
  public static void Main(string[] args) {
    ArbolBinario arbol = new ArbolBinario();
    
    arbol.Insertar(35);
    arbol.Insertar(50);
    arbol.Insertar(45);
    arbol.Insertar(500);
    arbol.Insertar(25);
    arbol.Insertar(75);
    arbol.Insertar(150);
    arbol.Insertar(105);
    arbol.Insertar(502);
    
    Console.WriteLine("¿Cuántos nodos hay en el árbol?: {0}", arbol.Cantidad());
    Console.WriteLine("¿Cuántos nodos son hijos?: {0}", arbol.CantidadHijos());
    Console.WriteLine("Impresión Pre-Orden: ");
    arbol.ImprimirPreOrden();
    Console.WriteLine("Impresión del Pre-Orden con su nivel correspondiente: ");
    arbol.ImprimirPreOrdenConNivel();
    Console.WriteLine("Altura del árbol: {0}", arbol.Altura());
    arbol.NodoMayor();
    arbol.NodoMenor();
    Console.WriteLine("Eliminación del hijo menor");
    arbol.EliminarNodoMenor();
    Console.WriteLine("Impresión In-Orden: ");
    arbol.ImprimirInOrden();
    arbol.EliminarNodoMayor();
    Console.WriteLine("Impresión Post-Orden");
    arbol.ImprimirPostOrden();
  }
}