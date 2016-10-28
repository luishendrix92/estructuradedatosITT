using System;
using System.Threading;

static class ControladorPrincipal {
  // MENUS Y CAPTURA DE TECLAS
  //----------------------------------------------
  public static void Menu(ArbolBinario arbol) {
    ConsoleKeyInfo tecla;
    
    do {
      Vista.MenuPrincipal(arbol);
      tecla = Console.ReadKey(true);
      
      switch (tecla.Key.ToString()) {
        case "D1":
          MP_T1_Insertar(arbol);
          break;
        case "D2":
          MP_T2_PreOrdNiv(arbol);
          break;
        case "D3":
          MP_T3_InOrdNiv(arbol);
          break;
        case "D4":
          MP_T4_PostOrdNiv(arbol);
          break;
        case "D5":
          MP_T5_EliminarMenor(arbol);
          break;
        case "D6":
          MP_T6_EliminarMayor(arbol);
          break;
        case "D7":
          MP_T7_MasInformacion(arbol);
          break;
        case "D8":
          arbol.Limpiar();
          break;
      }
    } while (tecla.Key != ConsoleKey.Escape);
  }
  
  // MANEJO DE ACCIÓN POR TECLA PRESIONADA
  //--------------------------------------------------------------
  public static void MP_T1_Insertar(ArbolBinario arbol) {
    bool leido = true;
    
    Console.Write("Dame dato para insertar en árbol: ");
    int dato = Helpers.LeerNumero(ref leido);
    
    if (leido) arbol.Insertar(dato);
    if (!leido) Thread.Sleep(1500);
  }
  
  public static void MP_T2_PreOrdNiv(ArbolBinario arbol) {
    Console.Clear();
    arbol.ImprimirPreOrdenConNivel();
    Helpers.Prompt();
  }
  
  public static void MP_T3_InOrdNiv(ArbolBinario arbol) {
    Console.Clear();
    arbol.ImprimirInOrdenConNivel();
    Helpers.Prompt();
  }
  
  public static void MP_T4_PostOrdNiv(ArbolBinario arbol) {
    Console.Clear();
    arbol.ImprimirPostOrdenConNivel();
    Helpers.Prompt();
  }
  
  public static void MP_T5_EliminarMenor(ArbolBinario arbol) {    
    if (!arbol.EstaVacio) {
      arbol.EliminarNodoMenor();
      Console.Write("ÉXITO: Se eliminó el nodo menor :)");
    } else {
      Console.Write("FRACASO: El árbol está vacío!");
    }
    
    Thread.Sleep(1500);
  }
  
  public static void MP_T6_EliminarMayor(ArbolBinario arbol) {    
    if (!arbol.EstaVacio) {
      arbol.EliminarNodoMayor();
      Console.Write("ÉXITO: Se eliminó el nodo mayor :)");
    } else {
      Console.Write("FRACASO: El árbol está vacío!");
    }
    
    Thread.Sleep(1500);
  }
  
  public static void MP_T7_MasInformacion(ArbolBinario arbol) {
    Console.Clear();
    
    Console.WriteLine("Este árbol tiene {0} de nodos en total.",
      arbol.Cantidad());
    Console.WriteLine("De todos esos nodos, {0} son hijos (hojas)!",
      arbol.CantidadHijos());
    Console.WriteLine("Tiene una altura de {0} y el nivel máximo es {1}.",
      arbol.Altura(), arbol.Niveles);
    if (!arbol.EstaVacio) {
      Console.WriteLine("Nodo mayor: {0} | Nodo menor: {1}.",
        arbol.NodoMayor(), arbol.NodoMenor());
    } else {
      Console.WriteLine("El árbol está vacío, acaso no lo notas? :(");
    }
    
    Helpers.Prompt();
  }
}

/* Helpers para Controlador
-------------------------------------------------------*/
class Helpers {
  public static int LeerNumero(ref bool leido) {
    int numeroLeido = 0;
    
    try {
      numeroLeido = Int32.Parse(Console.ReadLine());
    } catch {
      leido = false;
      Console.WriteLine("ERROR DE LECTURA O FORMATO!!");
    }
    
    return numeroLeido;
  }
  
  public static int[] NumerosRandom(int n, int a, int b) {
    if (n == 0) n = 10;
    
    int[] numeros = new int[n];
    Random rand = new Random();
    int numRandom;

    for (int i = 0; i < n; i++) {
      do {
      	numRandom = rand.Next(a, b);
      } while (Array.IndexOf(numeros, numRandom) >= 0);

      numeros[i] = numRandom;
    }

    return numeros;
  }
  
  public static void Prompt() {
    Console.Write("\nPresione cualquier tecla para continuar... ");
    Console.ReadKey(true);
  }
}