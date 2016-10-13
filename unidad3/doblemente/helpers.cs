using System;

static class Helpers {
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
}