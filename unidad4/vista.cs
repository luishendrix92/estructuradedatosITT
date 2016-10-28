using System;

static class Vista {
  public static void MenuPrincipal(ArbolBinario arbol) {
    Console.Clear();
    
    Console.WriteLine("REPRESENTACIÓN VISUAL | Nodos = {0}", arbol.Cantidad());
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Pre-Orden:");
    arbol.ImprimirPreOrden();
    Console.WriteLine("In-Orden:");
    arbol.ImprimirInOrden();
    Console.WriteLine("Post-Orden:");
    arbol.ImprimirPostOrden();
    Console.WriteLine("_____________________________________________________\n");
    
    Console.WriteLine(".---.        .---.        .---.        .---.");
    Console.WriteLine("| 1 |        | 2 |        | 3 |        | 4 |");
    Console.WriteLine("'==='        '==='        '==='        '==='");
    Console.WriteLine("Insertar     Pr.O Nivel   In.O Nivel   Po.O Nivel\n");
    
    Console.WriteLine(".---.        .---.        .---.        .---.");
    Console.WriteLine("| 5 |        | 6 |        | 7 |        | 8 |");
    Console.WriteLine("'==='        '==='        '==='        '==='");
    Console.WriteLine("Elim. Men.   Elim. May.   +Info        Limpiar\n");
    Console.WriteLine("[ESC] para salir del programa!");
  }
}