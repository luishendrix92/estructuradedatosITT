using System;

class Nodo {
  public Nodo anterior, siguiente;
  public int dato;
  
  public Nodo
  (int dat, Nodo ant = null, Nodo sig = null) {
    this.dato      = dat;
    this.anterior  = ant;
    this.siguiente = sig;
  }
  
  // MÉTODOS PÚBLICOS ESTÁTICOS
  // ----------------------------------------------------
  public static Nodo Ultimo(Nodo actual) {
    if (actual.siguiente == null) return actual;
    
    return Nodo.Ultimo(actual.siguiente);
  }
  
  public static Nodo Brincar(Nodo actual, int brincos) {
    if (brincos == 0) return actual;
    
    return Nodo.Brincar(actual.siguiente, brincos - 1);
  }
  
  public static Nodo Reversa(Nodo actual, Nodo _reversa) {
    if (actual.siguiente == null) return _reversa;
    
    _reversa = new Nodo(actual.siguiente.dato, null, _reversa);
    _reversa.siguiente.anterior = _reversa;
    
    return Reversa(actual.siguiente, _reversa);
  }
  
  public static void Swap(Nodo a, Nodo b) {
    if (a != b) {
      int temp_a = a.dato;
      
      a.dato = b.dato;
      b.dato = temp_a;
    }
  }
}