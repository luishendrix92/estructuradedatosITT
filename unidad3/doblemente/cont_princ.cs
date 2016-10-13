using System;
using System.Threading;

static class ControladorPrincipal {
  // MENUS Y CAPTURA DE TECLAS
  //----------------------------------------------
  public static void Menu(ListaDE lista) {
    ConsoleKeyInfo tecla;
    
    do {
      Vista.MenuPrincipal(lista);
      tecla = Console.ReadKey(true);
      
      switch (tecla.Key.ToString()) {
        case "D1":
          MP_T1_PUSH(lista);
          break;
        case "D2":
          MP_T2_POP(lista);
          break;
        case "D3":
          MP_T3_SHIFT(lista);
          break;
        case "D4":
          MP_T4_UNSHIFT(lista);
          break;
        case "D5":
          MP_T5_BORRAR(lista);
          break;
        case "D6":
          lista.Limpiar();
          break;
        case "D7":
          ControladorInsertar.Menu(lista);
          break;
        case "D8":
          lista.Ordenar();
          break;
        case "D9":
          lista.Reversa();
          break;
        case "D0":
          MP_T0_SWAP(lista);
          break;
        case "A":
          MP_TA_EDITAR(lista);
          break;
        case "B":
          MP_TB_BUSCAR(lista);
          break;
        case "C":
          MP_TC_OBTENER(lista);
          break;
      }
    } while (tecla.Key != ConsoleKey.Escape);
  }
  
  // MANEJO DE ACCIÓN POR TECLA PRESIONADA
  //--------------------------------------------------------------
  public static void MP_T1_PUSH(ListaDE lista) {
    bool leido = true;
    
    Console.Write("Dame dato para empujar: ");
    int dato = Helpers.LeerNumero(ref leido);
    
    if (leido) lista.Push(dato);
    if (!leido) Thread.Sleep(1500);
  }
  
  public static void MP_T2_POP(ListaDE lista) {
    int datoExtraido = lista.Pop();
    Console.WriteLine("Dato extraído: {0}", datoExtraido);
    Thread.Sleep(1500);
  }
  
  public static void MP_T3_SHIFT(ListaDE lista) {
    int datoExtraido = lista.Shift();
    Console.WriteLine("Dato extraído: {0}", datoExtraido);
    Thread.Sleep(1500);
  }
  
  public static void MP_T4_UNSHIFT(ListaDE lista) {
    bool leido = true;
    
    Console.Write("Dame dato para encolar: ");
    int dato = Helpers.LeerNumero(ref leido);
    
    if (leido) lista.Unshift(dato);
    if (!leido) Thread.Sleep(1500);
  }
  
  public static void MP_T5_BORRAR(ListaDE lista) {
    bool leido = true;
    
    Console.Write("¿Qué index quieres borrar? ");
    int index    = Helpers.LeerNumero(ref leido);
    bool seBorro = leido? lista.Borrar(index) : false;
    
    Console.WriteLine("¿Dato en index {0} borrado?: {1}",
      index, seBorro? "ÉXITO :)" : "FRACASO!!");
    Thread.Sleep(1500);
  }
  
  public static void MP_T0_SWAP(ListaDE lista) {
    bool leido_a = true, leido_b = true;
    
    Console.Write("Índice (a) para intercambiar: ");
    int index_a = Helpers.LeerNumero(ref leido_a);
    Console.Write("Índice (b) para intercambiar: ");
    int index_b = Helpers.LeerNumero(ref leido_b);
    
    bool swapped = (leido_a && leido_b)?
      lista.Swap(index_a, index_b) : false;
    Console.WriteLine("Intercambio entre índices {0} y {1} {2}!!",
      index_a, index_b, swapped? "EXITOSO" : "FRACASÓ");
    Thread.Sleep(1500);
  }
  
  public static void MP_TA_EDITAR(ListaDE lista) {
    bool leido_a = true, leido_b = true;
    
    Console.Write("Índice a reemplazar: ");
    int index = Helpers.LeerNumero(ref leido_a);
    Console.Write("Dato nuevo en índice {0}: ", index);
    int dato  = Helpers.LeerNumero(ref leido_b);
    
    bool reemplazado = (leido_a && leido_b)?
      lista.Reemplazar(index, dato) : false;
    Console.WriteLine("Reemplazo {0}",
      reemplazado? "EXITOSO!" : "FRACASÓ!!");
    Thread.Sleep(1500);
  }
  
  public static void MP_TB_BUSCAR(ListaDE lista) {
    bool leido = true;
    
    Console.Write("Dato que quieres buscar: ");
    int dato  = Helpers.LeerNumero(ref leido);
    int idxAt = lista.Buscar(dato);
    
    if (leido) Console.WriteLine("El dato {0} {1}",
      dato, (idxAt < 0)? "no fue encontrado" :
      "se encuentra en el índice " + idxAt);
    Thread.Sleep(1500);
  }
  
  public static void MP_TC_OBTENER(ListaDE lista) {
    bool leido = true;
    
    Console.Write("Dame el índice del dato a obtener: ");
    int index = Helpers.LeerNumero(ref leido);
    int dato  = lista.EnIndex(index);
    
    if (leido) Console.WriteLine("Se encontró {0} en el índice {1}!",
      dato, index);
    Thread.Sleep(1500);
  }
}