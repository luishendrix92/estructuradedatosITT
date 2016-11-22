using System;

class Conteo {
  public int[] arr = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
  
  public void Acumular() {
    for (int i = 1, len = arr.Length; i < len; i++) {
      arr[i] = arr[i] + arr[i - 1];
    }
  }
  
  public void Resetear() {
    arr = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
  }
  
  // Funciones de ayuda para el manejo de dígitos
  public static int Digitos(int num, int digitos = 1) {
    if ((num / 10) == 0) return digitos;
      
    return Conteo.Digitos(num / 10, digitos + 1);
  }
  
  public static int Digito(int num, int digitNum, int digito = 0) {
    if (digitNum == 0) return digito;
      
    return Conteo.Digito(num / 10, digitNum - 1, num % 10);
  }
  
  public static int MaxDigitos(int[] numeros) {
    int maxDig = 0;
      
    for (int i = 0, len = numeros.Length; i < len; i++) {
      int digitosActual = Conteo.Digitos(numeros[i]);
      if (digitosActual > maxDig) maxDig = digitosActual;
    }
      
    return maxDig;
  }
}

class Radix {
  public static void Sort(int[] lista) {
    // Variables de estado
    int maxDigitos = Conteo.MaxDigitos(lista), digitoActual;
    int[] ordenada = new int[lista.Length];
    Conteo conteo = new Conteo();
    
    for (int dig = 1, len = lista.Length; dig <= maxDigitos; dig++) {
      // Recorrer de izquierda a derecha
      for (int i = 0; i < len; i++) {
        digitoActual = Conteo.Digito(lista[i], dig);
        conteo.arr[digitoActual]++;
      }
      
      conteo.Acumular();
      
      // Recorrer de derecha a izquierda
      for (int i = len - 1; i >= 0; i--) {
        digitoActual = Conteo.Digito(lista[i], dig);
        ordenada[--conteo.arr[digitoActual]] = lista[i];
      }
      
      conteo.Resetear();
      Array.Copy(ordenada, lista, len);
    }
  }  
}

class Programa {
  public static int[] ArregloLleno() {
    int cant = 15, randNum, a = 1, b = cant;
    Random rand = new Random();
    int[] arreglo = new int[cant];
    
    for (int i = 0; i < cant; i++) {
      do {
        randNum = rand.Next(a, b + 1);
      } while (Array.IndexOf(arreglo, randNum) >= 0);
      
      arreglo[i] = randNum;
    }
    
    return arreglo;
  }
  
  static void Main(string[] args) {
    int[] arreglo = Programa.ArregloLleno();
    
    Console.WriteLine("Desordenado:");
    Console.WriteLine("-----------------------------------");
    foreach (int n in arreglo) {
      Console.Write("{0} ", n);
    }
    
    Radix.Sort(arreglo);
    
    Console.WriteLine("\n\nOrdenado:");
    Console.WriteLine("-----------------------------------");
    foreach (int n in arreglo) {
      Console.Write("{0} ", n);
    }
  }
}