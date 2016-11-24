using System;

class NaturalMS {
  int[] temp;

  public void Sort(int[] arreglo) {
    temp = new int[arreglo.Length];
    NaturalMergeSort(arreglo);
  }
  
  void NaturalMergeSort(int[] arreglo) {
    int izq = 0, der = arreglo.Length - 1,
      _izq = 0, _der = der;
    bool ordenado = false;
    
    do {
      ordenado = true;
      izq      = 0;
      
      while (izq < der) {
        _izq = izq;
        while (_izq < der && arreglo[_izq] <= arreglo[_izq+1]) _izq++;
        _der = _izq + 1;
        while (_der == der-1 || _der < der && arreglo[_der] <= arreglo[_der+1]) _der++;
        
        if (_der <= der) {
          Merge(arreglo, izq, _izq, _der);
          ordenado = false;
        }
        
        izq = _der + 1;
      }
    } while (!ordenado);
  }
  
  void Merge(int[] arreglo, int izq, int medio, int der) {
    int _izq = izq;
    int _der = medio + 1;
    
    for (int i = izq; i <= der; i++) {
      if (_der > der || (_izq <= medio && arreglo[_izq] <= arreglo[_der]))
        temp[i] = arreglo[_izq++];
      else if (_izq > medio || (_der <= der && arreglo[_der] <= arreglo[_izq]))
        temp[i] = arreglo[_der++];
    }
    
    for (int i = izq; i <= der; i++)
      arreglo[i] = temp[i];
  }
  
}

class Programa {
  static void Main(string[] args) {
    int cant      = 10, randNum;
    int[] nums    = new int[cant];
    Random rand   = new Random();
    NaturalMS nms = new NaturalMS();
    
    for (int i = 0; i < cant; i++) {
      do {
        randNum = rand.Next(1, cant + 1);
      } while (Array.IndexOf(nums, randNum) >= 0);
      
      nums[i] = randNum;
    }
    
    ImprimirLista(nums, "Lista desordenada:");
    nms.Sort(nums);
    ImprimirLista(nums, "\nLista ordenada por Natural Merge:");
  }
  
  static void ImprimirLista(int[] lista, string caption) {
    Console.WriteLine("{0}", caption);
    Console.WriteLine("---------------------------------");
    foreach (int item in lista)
      Console.Write("{0} -> ", item);
    Console.WriteLine("FIN");
  }
}