using System;

static class Vista {
  public static void MenuPrincipal(ListaDE lista) {
    Console.Clear();
    
    Console.WriteLine("REPRESENTACIÓN VISUAL");
    Console.WriteLine("---------------------\n");
    lista.Mostrar();
    Console.WriteLine("\nPresione cualquiera de las siguientes teclas o");
    Console.WriteLine("presione la tecla [ESC] para salir del programa:\n");
    
    Console.WriteLine(".---.  .---.  .---.  .---.    .---.   .---.    .---.");
    Console.WriteLine("| 1 |  | 2 |  | 3 |  | 4 |    | 5 |   | 6 |    | 7 |");
    Console.WriteLine("'==='  '==='  '==='  '==='    '==='   '==='    '==='");
    Console.WriteLine("Push   Pop    Shift  Unshift  Borrar  Limpiar  Insertar\n");
    
    Console.WriteLine(".---.    .---.    .---.  .---.   .---.   .---.");
    Console.WriteLine("| 8 |    | 9 |    | 0 |  | A |   | B |   | C |");
    Console.WriteLine("'==='    '==='    '==='  '==='   '==='   '==='");
    Console.WriteLine("Ordenar  Reversa  Swap   Editar  Buscar  Obtener\n");
  }
  
  public static void MenuInsertar(ListaDE lista) {
    Console.Clear();
    
    Console.WriteLine("REPRESENTACIÓN VISUAL");
    Console.WriteLine("---------------------\n");
    lista.Mostrar();
    Console.WriteLine("\nPresione cualquiera de las siguientes teclas o");
    Console.WriteLine("la tecla [ESC] para volver al menú principal:\n");
    
    Console.WriteLine(".---.     .---.     .---.");
    Console.WriteLine("| 1 |     | 2 |     | 3 |");
    Console.WriteLine("'==='     '==='     '==='");
    Console.WriteLine("Insertar  Insertar  Insertar");
    Console.WriteLine("Ordenado  Frente a  Detrás de\n");
  }
}