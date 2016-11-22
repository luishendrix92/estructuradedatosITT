using System;

class QuickSort {
  int tamaño;
  int[] arreglo;
  
  /*public QuickSort(int _tamaño) {
    tamaño = _tamaño;
    arreglo = new int[tamaño];
    
    for (int i = 0; i < arreglo.Length; i++) {
      Console.Write("Ingresa el dato {0}: ", i + 1);
      arreglo[i] = Int32.Parse(Console.ReadLine());
    }
    
    quicksort(arreglo, 0, tamaño - 1);
    mostrar();
  }*/
  
  /* Genera datos random */
  public QuickSort(int _tamaño) {
    tamaño = _tamaño;
    arreglo = new int[_tamaño];
    Random rand = new Random();
    int randNum;
    
    for (int i = 0; i < arreglo.Length; i++) {
      do {
        randNum = rand.Next(tamaño + 1);
      } while (Array.IndexOf(arreglo, randNum) >= 0);
      
      arreglo[i] = randNum;
    }
    
    quicksort(arreglo, 0, tamaño - 1);
    mostrar();
  }
  
  private void quicksort(int[] _arreglo, int _primero, int _ultimo) {
    int primero, ultimo, elementocentral;
    double pivote;
    
    elementocentral = (_primero + _ultimo) / 2;
    pivote = _arreglo[elementocentral];
    primero = _primero;
    ultimo = _ultimo;
    
    do {
      while (_arreglo[primero] < pivote) primero++;
      while (_arreglo[ultimo] > pivote) ultimo--;
      
      if (primero <= ultimo) {
        int temporal;
        temporal = _arreglo[primero];
        _arreglo[primero] = _arreglo[ultimo];
        _arreglo[ultimo] = temporal;
        primero++;
        ultimo--;
      }
    } while (primero <= ultimo);
    
    if (_primero < ultimo) {
      quicksort(_arreglo, _primero, ultimo);
    }
    
    if (primero < _ultimo) {
      quicksort(_arreglo, primero, _ultimo);
    }
  }
  
  private void mostrar() {
    Console.WriteLine("Datos Ordenados");
    
    foreach (int n in arreglo) {
      Console.Write("{0} ", n);
    }
  }
}

class Programa {
  static void Main() {
    Console.WriteLine("Indica el tamaño del arreglo: ");
    int tamaño;
    tamaño = Int32.Parse(Console.ReadLine());
    
    QuickSort qs = new QuickSort(tamaño);
  }
}