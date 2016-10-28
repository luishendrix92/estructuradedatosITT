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
  
  public static void InOrden(Nodo actual, int nivel = 0) {
    if (actual != null) {
      bool esHoja = actual.izq == null && actual.der == null;
      bool esRaiz = nivel == 0;
      string apendice = esHoja? "| Hoja" : esRaiz? "| Raiz" : "";

      Arbol.InOrden(actual.izq, nivel + 1);
      Console.WriteLine("Nivel {0}: {1} {2}",
        nivel, actual.dato, apendice);
      Arbol.InOrden(actual.der, nivel + 1);
    }
  }
  
  public static void PreOrden(Nodo actual, int nivel = 0) {
    if (actual != null) {
      bool esHoja = actual.izq == null && actual.der == null;
      bool esRaiz = nivel == 0;
      string apendice = esHoja? "| Hoja" : esRaiz? "| Raiz" : "";

      Console.WriteLine("Nivel {0}: {1} {2}",
        nivel, actual.dato, apendice);
      Arbol.PreOrden(actual.izq, nivel + 1);
      Arbol.PreOrden(actual.der, nivel + 1);
    }
  }
  
  public static void PostOrden(Nodo actual, int nivel = 0) {
    if (actual != null) {
      bool esHoja = actual.izq == null && actual.der == null;
      bool esRaiz = nivel == 0;
      string apendice = esHoja? "| Hoja" : esRaiz? "| Raiz" : "";

      Arbol.PostOrden(actual.izq, nivel + 1);
      Arbol.PostOrden(actual.der, nivel + 1);
      Console.WriteLine("Nivel {0}: {1} {2}",
        nivel, actual.dato, apendice);
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

    tree.Raiz.dato = "5";

    tree.Raiz.izq  = new Nodo(
      "3",
      new Nodo(
        "1",
        new Nodo("0")
      ),
      new Nodo("4")
    );
    tree.Raiz.der  = new Nodo(
      "7",
      new Nodo("6"),
      new Nodo(
        "9",
        new Nodo("8"),
        new Nodo("10")
      )
    );

    Console.WriteLine("PRE-ORDEN:");
    Arbol.PreOrden(tree.Raiz);
    Console.WriteLine("------------------------");
    Console.WriteLine("IN-ORDEN:");
    Arbol.InOrden(tree.Raiz);
    Console.WriteLine("------------------------");
    Console.WriteLine("POST-ORDEN:");
    Arbol.PostOrden(tree.Raiz);
    Console.WriteLine("------------------------");

    Console.WriteLine("\nNiveles: {0}", tree.Niveles);
    Console.WriteLine("Altura: {0}", tree.Altura);
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