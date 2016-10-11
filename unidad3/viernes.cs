public class CListaLinealSE<T> {
  private class CElemento {
    public T datos;
    public CElemento siguiente;
    
    public CElemento() {}
    
    public CElemento(T d, CElemento s) {
      datos = d; siguiente = s;
    }
  }
  
  // p: Referencia al primer elemento de la lista
  // Es el elemento de cabecera
  private CElemento p         = null;
  private int numeroElementos = 0;
  
  public CListaLinealSE() {}
  
  public int Tamaño {
    get { return numeroElementos; }
  }
  
  public bool Añadir(int i, T obj) {
    if (i > numeroElementos || i < 0) {
      Console.WriteLine("Índice fuera de límites");
      return false;
    }

    CElemento q = new CElemento(obj, null);

    if (numeroElementos == 0) {
      p = q;
      numeroElementos++;
      return true;
    }
    
    // Si la lista no está vacia, encuentra el punto de insercion
    CElemento elemAnterior = p;
    CElemento elemActual   = p;

    for (int n = 0; n < i; n++) {
      elemAnterior = elemActual;
      elemActual   = elemActual.siguiente;
    }
    
    if (elemAnterior == elemActual) {
      q.siguiente = p;
      p           = q;
    } else {
      q.siguiente = elemActual;
      elemAnterior.siguiente = q;
    }
    
    numeroElementos++;
    return true;
  }
  
  public bool AñadirPrincipio(T obj) {
    return Añadir(0, obj);
  }
  
  public bool AñadirFinal(T obj) {
    return Añadir(Tamaño, obj);
  }
  
  public bool Borrar(int i) {
    if (i >= numeroElementos || i < 0) {
      return false;
    }
    
    // Encontrar el indice del elemento
    CElemento elemAnterior = p;
    CElemento elemActual   = p;
    
    for (int n = 0; n < i; n++) {
      elemAnterior = elemActual;
      elemActual   = elemActual.siguiente;
    }
    
    if (elemActual == p) {
      p = p.siguiente;
    } else {
      elemAnterior.siguiente = elemActual.siguiente;
    }
    
    numeroElementos--;
    return true;
  }
  
  public bool BorrarPrimero() {
    return Borrar(0);
  }
  
  public bool BorrarUltimo() {
    return Borrar(Tamaño - 1);
  }
  
  public bool Obtener(out T e, int i) {
    e = default(T);
    
    if (i >= numeroElementos || i < 0) {
      return false;
    }
    
    CElemento q = p;

    for (int n = 0; n < i; n++) {
      q = q.siguiente;
    }
    
    e = q.datos;
    return true;
  }
  
  public bool ObtenerPrimero(out T e) {
    e = default(T);
    return Obtener(out e, 0);
  }
  
  public bool ObtenerUltimo(out T e) {
    e = default(T);
    return Obtener(out e, Tamaño - 1);
  }
}