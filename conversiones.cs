using System;
using System.Collections.Generic;

class Conversiones {
  private const string ERROR_COMP_HEX = "El dígito no es compatible con el sistema hexadecimal";
  
  public static string ensamblarDigito(int n, int nuevaBase) {
    if (n > 15 || n < 0) throw new Exception(ERROR_COMP_HEX);
    
    if (nuevaBase == 16) {
      return (n >= 10)? ((char)(n + 55)).ToString() : n.ToString();
    } else { // nuevaBases sin letras del alfabeto
      return n.ToString();
    }
  }
  
  public static void convertirDecimal(int n, int nuevaBase) {
    if (n >= nuevaBase) {
      convertirDecimal(n / nuevaBase, nuevaBase);
      
      Console.Write("{0}", ensamblarDigito(n % nuevaBase, nuevaBase));
    } else {
      Console.Write("{0}", ensamblarDigito(n, nuevaBase));
    }
  } // Fin de conversión recursiva
}

class Programa {
  static void Main(string[] args) {
    // Limpiar Pantalla
    Console.Clear();
    
    Console.Write("Introduzca un número entero:");
    
    int numero = Int32.Parse(Console.ReadLine());
    
    // Imprimir conversiones en pantalla
    Console.Write("\nNúmero: {0}, en código binario:", numero);
    Conversiones.convertirDecimal(numero, 2);
    Console.Write("\n");
    
    Console.Write("\nNúmero: {0}, en sistema octal:", numero);
    Conversiones.convertirDecimal(numero, 8);
    Console.Write("\n");
    
    Console.Write("\nNúmero: {0}, en sistema hexadecimal:", numero);
    Conversiones.convertirDecimal(numero, 16);
    Console.Write("\n");
  }
}
