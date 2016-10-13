using System;

class ListaDE {
  private Nodo raiz = null;
  public int Length = 0;
  
  public bool EstaVacia {
    get { return raiz == null; }
  }
  
  public int Primero {
    get { return EstaVacia? -1 : raiz.dato; }
  }
  
  public int Ultimo {
    get {
      return EstaVacia? -1 : Nodo.Ultimo(raiz).dato;
    }
  }
  
  public int Cantidad {
    get { return Length; }
  }
  
  // MÉTODOS PÚBLICOS ESTÁTICOS E INSTANCIADOS
  //---------------------------------------------------------
  // Para la lectura de datos
  public int EnIndex(int index) {
    if (index + 1 > Length || index < 0) return -1;
    
    return Nodo.Brincar(raiz, index).dato;
  }
  
  public void Mostrar() {
    if (EstaVacia) {
      Console.WriteLine("[ ] | n = 0");
    } else if (Length == 1) {
      Console.WriteLine("null<-[{0}]->null | n = 1", raiz.dato);
    } else {
      Nodo actual = raiz;
      
      Console.Write("null");
      while (actual != null) {
        Console.Write("<-[{0}]->", actual.dato);
        actual = actual.siguiente;
      }
      Console.Write("null | n = {0}\n", Length);
    }
  }
  
  // Para la inserción de datos
  public void Push(int dato) {
    if (EstaVacia) {
      raiz = new Nodo(dato);
    } else {
      Nodo final = Nodo.Ultimo(raiz);
      
      final.siguiente = new Nodo(dato, final);
    }
    
    Length++;
  }
  
  public void Unshift(int dato) {
    if (EstaVacia) {
      raiz = new Nodo(dato);
    } else {
      Nodo inicial = raiz;
      
      raiz = new Nodo(dato, null, inicial);
      inicial.anterior = raiz;
    }
    
    Length++;
  }
  
  public void InsEnSuLugar(int dato) {
    if (EstaVacia) {
      Push(dato);
    } else {
      Nodo actual = raiz;
      int i = 0;
      
      do {
        if (actual.dato >= dato) break;
        actual = actual.siguiente;
        i++;
      } while (actual != null);
      
      if (i == Length) {
        Push(dato);
      } else {
        InsDetrasDe(i, dato);
      }
    }
  }
  
  public bool InsFrenteA(int index, int dato) {
    if (index + 1 > Length || index < 0) return false;
    
    Nodo objetivo  = Nodo.Brincar(raiz, index);
    Nodo recorrido = objetivo.siguiente;
    Nodo insertado = new Nodo(dato, objetivo, recorrido);
    
    objetivo.siguiente = insertado;
    if (recorrido != null) recorrido.anterior = insertado;
    
    Length++;
    return true;
  }
  
  public bool InsDetrasDe(int index, int dato) {
    if (index + 1 > Length || index < 0) return false;
    
    if (index == 0) {
      Unshift(dato);
    } else {
      Nodo objetivo  = Nodo.Brincar(raiz, index);
      Nodo recorrido = objetivo.anterior;
      Nodo insertado = new Nodo(dato, recorrido, objetivo);
      
      recorrido.siguiente = insertado;
      objetivo.anterior = insertado;
      Length++;
    }
    
    return true;
  }
  
  // Para el borrado de datos
  public int Pop() {
    if (EstaVacia) return -1;
    
    Nodo final = Nodo.Ultimo(raiz);
    Nodo penultimo = final.anterior;
    
    if (penultimo != null) {
      penultimo.siguiente = null;
    } else {
      raiz = null;
    }
    
    Length--;
    return final.dato;
  }
  
  public int Shift() {
    if (EstaVacia) return -1;
    
    Nodo inicial = raiz;
    
    raiz = inicial.siguiente;
    if (!EstaVacia) raiz.anterior = null;
    
    Length--;
    return inicial.dato;
  }
  
  public bool Borrar(int index) {
    if (index + 1 > Length || index < 0) return false;
    
    if (index == 0) {
      Shift();
    } else if (index + 1 == Length) {
      Pop();
    } else {
      Nodo objetivo  = Nodo.Brincar(raiz, index);
      Nodo izquierda = objetivo.anterior;
      Nodo derecha   = objetivo.siguiente;
      
      izquierda.siguiente = derecha;
      derecha.anterior = izquierda;
      Length--;
    }
    
    return true;
  }
  
  public void Limpiar() { raiz = null; Length = 0; }
  
  // Métodos de ayuda y opearación
  public bool Swap(int index_a, int index_b) {
    bool swapInvalido = index_a == index_b ||
      index_a + 1 > Length ||
      index_b + 1 > Length;
      
    if (swapInvalido) return false;
      
    Nodo a = Nodo.Brincar(raiz, index_a);
    Nodo b = Nodo.Brincar(raiz, index_b);
    int temp_a = a.dato;
    
    a.dato = b.dato;
    b.dato = temp_a;
    
    return true;
  }
  
  public void Ordenar(bool ordenado = false) {
    if (Length > 1 && !ordenado) {
      Nodo actual = raiz;
      
      ordenado = true;      
      while (actual.siguiente != null) {
        if (actual.siguiente.dato < actual.dato) {
          Nodo.Swap(actual, actual.siguiente);
          ordenado = false;
        }
        actual = actual.siguiente;
      }
      // Llamada recursiva
      Ordenar(ordenado);
    }
  }
  
  public void Reversa() {
    if (!EstaVacia) {
      raiz = Nodo.Reversa(raiz, new Nodo(raiz.dato));
    }
  }
  
  public int Buscar(int dato) {
    return ListaDE.Buscar(dato, raiz);
  }
  
  public bool Reemplazar(int index, int dato) {
    if (index + 1 > Length || index < 0) return false;
    
    Nodo reemplazado = Nodo.Brincar(raiz, index);
    reemplazado.dato = dato;
    
    return true;
  }
  
  // MÉTODOS PRIVADOS ESTÁTICOS
  //---------------------------------------------------------
  private static int Buscar
  (int dato, Nodo actual, int index = 0) {
    if (actual == null) return -1;
    if (actual.dato == dato) return index;
    
    return Buscar(dato, actual.siguiente, index + 1);
  }
}

class Programa {
  static void Main(string[] args) {
    ListaDE lista = new ListaDE();
    
    ControladorPrincipal.Menu(lista);    
    Console.Clear();
  }
}

/*===============================================
/ NOTAS DE PIÉ
-------------------------------------------------
/ 1: La variable de estado 'Length' se puede
/ omitir si se implementa el siguiente getter:
/
/ public int Length {
/   get {
/     if (EstaVacia) return 0;
/
/     int length = 1;
/     Nodo actual  = raiz;
/
/     while (actual.siguiente != null) {
/       actual = actual.siguiente;
/       length++;
/     }
/     
/     return length;
/   }
/ }
/
/ El problema es que aumentaría la complejidad en
/ el tiempo a comparación de tenerla disponible.
===============================================*/