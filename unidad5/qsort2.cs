using System;

class QSort {
  private static int cont = 0;
  
  public void intercambio(int[] arreglo, int primero, int ultimo) {
    int temporal = arreglo[primero];
    
    arreglo[primero] = arreglo[ultimo];
    arreglo[ultimo] = temporal;
    cont++;
  }
  
  public int quicksort(int[] datos, int numero) {
    cont = 0;
    quicksort(datos, 0, numero - 1);
    
    return cont;
  }
  
  public void quicksort(int []arreglo, int _primero, int _ultimo) {
    if (_ultimo > _primero) {
      int pivote = arreglo[_ultimo];
      int primero = _primero - 1;
      int ultimo = _ultimo;
      
      do {
        while (arreglo[++primero] < pivote);
        while (arreglo[--ultimo] > pivote);
        
        if (primero < ultimo) {
          intercambio(arreglo, primero, ultimo);
        }
      } while (primero < ultimo);
      
      intercambio(arreglo, primero, _ultimo);
      quicksort(arreglo, _primero, primero - 1);
      quicksort(arreglo, primero + 1, _ultimo);
    }
    
  }
}

class Programa {
  static void Main(string[] args) {
    QSort qs = new QSort();
    int tamaño;
    int dato;
    
    Console.Write("Tamaño del arreglo: ");
    tamaño = int.Parse(Console.ReadLine());
    int[] arreglo = new int[tamaño];
    
    for (int n = 0; n < tamaño; ++n) {
      Console.Write("Ingresa el dato numero {0}: ", n + 1);
      dato = int.Parse(Console.ReadLine());
      arreglo[n] = dato;
    }
    
    qs.quicksort(arreglo, tamaño);
    Console.WriteLine("Impresion de datos ordenados");
    
    for (int n = 0; n < tamaño; ++n) {
      Console.Write("{0} ", arreglo[n]);
    }
  }
}