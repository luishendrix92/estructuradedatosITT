using System;
using System.Threading;

static class ControladorInsertar {
  // MENUS Y CAPTURA DE TECLAS
  //----------------------------------------------
  public static void Menu(ListaDE lista) {
    ConsoleKeyInfo tecla;

    do {
      Vista.MenuInsertar(lista);
      tecla = Console.ReadKey(true);
      
      switch (tecla.Key.ToString()) {
        case "D1":
          MI_T1_ORDENADO(lista);
          break;
        case "D2":
          MI_T2_FRENTE(lista);
          break;
        case "D3":
          MI_T3_ATRAS(lista);
          break;
      }
    } while (tecla.Key != ConsoleKey.Escape);
  }
  
  // MANEJO DE ACCIÓN POR TECLA PRESIONADA
  //--------------------------------------------------------------------
  public static void MI_T1_ORDENADO(ListaDE lista) {
    bool leido = true;
    
    Console.Write("¿Qué dato quieres insertar? ");
    int dato = Helpers.LeerNumero(ref leido);
    
    if (leido) lista.InsEnSuLugar(dato);    
    if (!leido) Thread.Sleep(1500);
  }
  
  public static void MI_T2_FRENTE(ListaDE lista) {
    bool leido_a = true, leido_b = true;
    
    Console.Write("¿Enfrente de qué índice vas a insertar? ");
    int index  = Helpers.LeerNumero(ref leido_a);
    Console.Write("Dame el dato a insertar: ");
    int dato   = Helpers.LeerNumero(ref leido_b);
    bool exito = (leido_a && leido_b)?
      lista.InsFrenteA(index, dato) : false;
    
    Console.WriteLine("Inserción del dato {0} frente al índice {1} {2}",
      dato, index, exito? "EXITOSA!" : "FRACASÓ!!");
    Thread.Sleep(1500);
  }
  
  public static void MI_T3_ATRAS(ListaDE lista) {
    bool leido_a = true, leido_b = true;
    
    Console.Write("¿Detrás de qué índice vas a insertar? ");
    int index  = Helpers.LeerNumero(ref leido_a);
    Console.Write("Dame el dato a insertar: ");
    int dato   = Helpers.LeerNumero(ref leido_b);
    bool exito = (leido_a && leido_b)?
      lista.InsDetrasDe(index, dato) : false;
    
    Console.WriteLine("Inserción del dato {0} atrás del índice {1} {2}",
      dato, index, exito? "EXITOSA!" : "FRACASÓ!!");
    Thread.Sleep(1500);
  }
}