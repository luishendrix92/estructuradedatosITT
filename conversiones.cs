using System;
using System.Collections.Generic;

class Conversiones {
  public static string EnsamblarDigito(int n, int nuevaBase) {    
    if (nuevaBase == 16) {
      return (n >= 10)? ((char)(n + 55)).ToString() : n.ToString();
    } else { // nuevaBases sin letras del alfabeto
      return n.ToString();
    }
  }
  
  public static void ConvertirDecimal(int n, int nuevaBase) {
    if (n >= nuevaBase) {
      ConvertirDecimal(n / nuevaBase, nuevaBase);
      
      Console.Write("{0}", EnsamblarDigito(n % nuevaBase, nuevaBase));
    } else {
      Console.Write("{0}", EnsamblarDigito(n, nuevaBase));
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
    Conversiones.ConvertirDecimal(numero, 2);
    Console.Write("\n");
    
    Console.Write("\nNúmero: {0}, en sistema octal:", numero);
    Conversiones.ConvertirDecimal(numero, 8);
    Console.Write("\n");
    
    Console.Write("\nNúmero: {0}, en sistema hexadecimal:", numero);
    Conversiones.ConvertirDecimal(numero, 16);
    Console.Write("\n");
  }
}
