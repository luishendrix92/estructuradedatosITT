class Nodo {
  public int dato;
  public Nodo sig;
  
  public Nodo(int dato, Nodo sig) {
    this.dato = dato;
    this.sig = sig;
  }
}

class ListaE {
  Nodo primero;
  Nodo actual;
  
  public ListaE() {}
  
  public bool ListaVacia() {
    return primero ==  null;
  }
  
  public void Insertar(int dato) {
    Nodo anterior;
    
    if (Listavacia() || primero.dato > dato) {
      primero = new Nodo(dato, primero);
    } else {
      anterior = primero;
      
      while (anterior.sig != null && anterior.sig.dato <= dato)
        anterior = anterior.sig;
        anterior.sig = new Nodo(dato, anterior.sig);
      }
    }
  }
  
  public void Mostrar() {
    Nodo auxiliar;
    auxiliar = primero;
    
    while (auxiliar != null) {
      Console.WriteLine(auxiliar.dato);
      auxiliar = auxiliar.sig;
    }
    
    Console.Write("Ya no hay otro elemento!");
  }
  
  public void Siguiente() {
    if (actual != null) actual = actual.sig;
  }
  
  public void Primero() {
    actual = primero;
  }

  public bool Actual() {
    return actual != null;
  }

  public int ValorActual() {
    return actual.dato;
  }

  public void Ultimo() {
    Primero();
    
    if (!ListaVacia()) {
      while (actual.sig != null) {
        Siguiente();
      }
    }
  }

  public void Borrar(dato) {
    Nodo anterior, nodo;
    nodo = primero;
    anterior = null;
    
    while (nodo != null && nodo.dato < dato) {
      anterior = nodo;
      nodo = nodo.sig;
    }
    
    if (nodo == null || nodo.dato != dato) return;
    
    if (anterior == null) {
      primero = nodo.sig;
    } else {
      anterior.sig = nodo.sig;
    }
  }
}

class Programa {
  static void Main() {
    ListaE LST = new ListaE();
    
    LST.Insertar(90);
    LST.Insertar(12);
    LST.Insertar(24);
    
    LST.Mostrar();
    LST.Borrar(90);
    LST.Mostrar();
  }
}
