using System;

class ListaC {
  class Nodo {
    public int dato;
    public Nodo anterior, siguiente;
  }
  
  private Nodo r;
  
  public ListaC() { r = null; }
  
  public void AgregarP(int _dato) {
    Nodo nvo = new Nodo();
    nvo.dato = _dato;
    
    if (r == null) {
      nvo.siguiente = nvo;
      nvo.anterior  = nvo;
      r             = nvo;
    } else {
      Nodo ultimo      = r.anterior;
      nvo.siguiente    = r;
      nvo.anterior     = ultimo;
      r.anterior       = nvo;
      ultimo.siguiente = nvo;
      r                = nvo;
    }
  }
  
  public void AgregarU(int _dato) {
    Nodo nvo = new Nodo();
    nvo.dato = _dato;
    
    if (r == null) {
      nvo.siguiente = nvo;
      nvo.anterior = nvo;
      r = nvo;
    } else {
      Nodo ultimo      = r.anterior;
      nvo.siguiente    = r;
      nvo.anterior     = ultimo;
      r.anterior       = nvo;
      ultimo.siguiente = nvo;
    }
  }
  
  public bool ListaVacia() {
    return r == null;
  }
  
  public void Mostrar() {
    int i = 1;
    
    if (!ListaVacia()) {
      Nodo reco = r;
      
      do {
        Console.WriteLine("{0} = {1}", i, reco.dato);
        reco = reco.siguiente;
        i++;
      } while (reco != r);
      
      Console.WriteLine();
    }
  }
  
  public int Cantidad() {
    int cantidad = 0;
    
    if (!ListaVacia()) {
      Nodo recorrer = r;
      
      do {
        cantidad++;
        recorrer = recorrer.siguiente;
      } while (recorrer != r);
    }
    
    return cantidad;
  }
  
  public void Borrar(int posicion) {
    if (posicion <= Cantidad()) {
      if (posicion == 1) {
        if (Cantidad() == 1) {
          r = null;
        } else {
          Nodo ultimo      = r.anterior;
          r                = r.siguiente;
          ultimo.siguiente = r;
          r.anterior       = ultimo;
        }
      } else {
        Nodo recorrer = r;
        
        for (int n = 1; n <= posicion - 1; n++) {
          recorrer = recorrer.siguiente;
        }
        
        Nodo anterior      = recorrer.anterior;
        recorrer           = recorrer.siguiente;
        anterior.siguiente = recorrer;
        recorrer.anterior  = anterior;
      }
    }
  }
}

class Programa {
  static void Main(string[] args) {
    ListaC circular = new ListaC();
    
    Console.WriteLine("Agregando los siguientes números: 55, 450, 22, 24, 25, 26");
    
    circular.AgregarP(55);
    circular.AgregarP(450);
    circular.AgregarP(22);
    circular.AgregarP(24);
    circular.AgregarP(25);
    circular.AgregarP(26);
    
    Console.WriteLine("Mostrando los números de la lista:");
    circular.Mostrar();
    
    Console.WriteLine("Agregando por el final de la lista: 888, 777, 556");
    circular.AgregarU(888);
    circular.AgregarU(777);
    circular.AgregarU(556);
    
    Console.WriteLine("Mostrando los números de la lista:");
    circular.Mostrar();
    
    Console.Write("¿Cuántos nodos hay?: ");
    Console.WriteLine(circular.Cantidad());
    Console.WriteLine("Borrar de la posición 3: '24'");
    circular.Borrar(3);
    circular.Mostrar();
    
    Console.WriteLine("Borrar de la psoción 6: '888'");
    circular.Borrar(6);
    circular.Mostrar();
  }
}