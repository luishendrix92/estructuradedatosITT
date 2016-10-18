using System;

class Nodo {
  public Nodo izq, der;
  public string dato;
  
  public Nodo
  (string v = null, Nodo i = null, Nodo d = null) {
    dato = v; izq = i; der = d;
  }
}

class Arbol {
  public Nodo Raiz = new Nodo();
  
  public int Altura {
    get { return Arbol.MaxNivel(Raiz) + 1; }
  }
  
  public int Niveles {
    get { return Arbol.MaxNivel(Raiz); }
  }

  public void Imprimir() {
    Arbol.Imprimir(Raiz);
  }
  
  private static void Imprimir(Nodo actual, int nivel = 0) {
    if (actual != null) {
      bool esHoja = actual.izq == null && actual.der == null;
      bool esRaiz = nivel == 0;
      string apendice = esHoja? " | Hoja" : esRaiz? " | Raiz" : "";
      
      Console.WriteLine("Nivel {0}: {1}{2}",
        nivel, actual.dato, apendice);
        
      Arbol.Imprimir(actual.izq, nivel + 1);
      Arbol.Imprimir(actual.der, nivel + 1);
    }
  }
  
  private static int MaxNivel(Nodo actual, int nivel = -1) {
    if (actual == null) return nivel;
    
    int izqNiv = Arbol.MaxNivel(actual.izq, nivel + 1);
    int derNiv = Arbol.MaxNivel(actual.der, nivel + 1);
    
    return Math.Max(izqNiv, derNiv);
  }
}

class Programa {
  static void Main(string[] args) {
    Arbol tree = new Arbol();
    
    tree.Raiz.dato = "A";
    
    tree.Raiz.izq  = new Nodo(
      "B",
      new Nodo("D"), // Hoja
      new Nodo(
        "E",
        new Nodo("G") // Hoja
      )
    );
    tree.Raiz.der  = new Nodo(
      "C",
      null,
      new Nodo("F") // Hoja
    );
    
    tree.Imprimir();
    
  Console.WriteLine("\nNiveles: {0}", tree.Niveles);
  }
}

/*======================
VISUAL DEL ÁRBOL BINARIO
------------------------
    0      [A]
           / \
    1    [B] [C]
         / \   \
    2  (D) [E] (F)
           /
    3    (G)
======================*/