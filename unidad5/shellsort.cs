using System;

class Shell {
  public int[] arreglo;
  public int tamaño;
  
  public void InsertarDatos() {
    Random rand = new Random();
    
    Console.Write("Indica el tamaño del arreglo: ");
    
    tamaño = Int32.Parse(Console.ReadLine());
    arreglo = new int[tamaño];
    
    for (int i = 0, len = arreglo.Length; i < len; i++) {
      arreglo[i] = rand.Next(100000 + 1);
    }
  }
  
  public void MetodoShell() {
    int salto       = 0;
    int intercambio = 0;
    int auxiliar    = 0;
    int e           = 0;
    
    salto = arreglo.Length / 2;
    
    while (salto > 0) {
      intercambio = 1;
      
      while (intercambio != 0) {
        intercambio = 0;
        e = 1;
        
        while (e <= (arreglo.Length - salto)) { 
          if(arreglo[e - 1] > arreglo[(e - 1) + salto]) {
            auxiliar = arreglo[(e - 1) + salto];
            arreglo[(e - 1) + salto] = arreglo[e - 1];
            arreglo[(e - 1)] = auxiliar;
            intercambio = 1;
          }
          
          e++;
        }
      }
      
      salto = salto / 2;
    }
  }
  
  public  void Mostrar() {
    Console.WriteLine("Datos Ordenados");
    Console.WriteLine("--------------------------");
    
    for (int i = 0; i < tamaño; i++) {
      Console.Write("{0} ", arreglo[i]);
    }
    
    Console.WriteLine();
  }
}

class Programa {
  static void Main() {
    Shell sh = new Shell();
    
    sh.InsertarDatos();
    sh.MetodoShell();
    sh.Mostrar();
  }
}