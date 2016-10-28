using System;
using System.Threading;

public class Nodo {
  public int dato;
  public Nodo izquierdo, derecho;
}

public class ArbolBinario {  
  private Nodo raiz = null;
  private int cantidad, altura;
  
  public int Niveles {
    get { return (raiz == null)? 0 : Altura() - 1; }
  }
  
  public bool EstaVacio {
    get { return raiz == null; }
  }
  
  public void Limpiar() {
    raiz = null;
  }
  
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
  
  public int NodoMayor() {
    if (raiz != null) {
      Nodo recorrer = raiz;
      
      while (recorrer.derecho != null) {
        recorrer = recorrer.derecho;
      }
      
      return recorrer.dato;
    } else {
      return -1;
    }
  }
  
  public int NodoMenor() {
    if (raiz != null) {
      Nodo recorrer = raiz;
      
      while (recorrer.izquierdo != null) {
        recorrer = recorrer.izquierdo;
      }
      
      return recorrer.dato;
    } else {
      return -1;
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
    ArbolBinario arbol  = new ArbolBinario();
    int[] numerosRandom;
    int nodos;
    bool leido = true;
    
    Console.Write("¿De cuántos nodos quieres el árbol?: ");
    nodos = Helpers.LeerNumero(ref leido);
    numerosRandom = Helpers.NumerosRandom(
      /* Va desde el 1 hasta 3 veces "n" mas 1, al azar */
      nodos, 1, (nodos > 0)? nodos * 3 + 1 : 100
    ); /* Si hubo error, 10 datos del 1 a 100, al azar */
    
    foreach (int num in numerosRandom) {
      arbol.Insertar(num);
    }
    
    ControladorPrincipal.Menu(arbol);    
    Console.Clear();
  }
}