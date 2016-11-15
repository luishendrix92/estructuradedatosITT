using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shell {
  public int[] arreglo;
  public int tamaño;
  public void InsertarDatos()
  {
    Random rnd = new Random();
    Console.Write("Indica el tamaño del arreglo: ");
    
    tamaño = Int32.Parse(Console.ReadLine());
    arreglo = new int[tamaño];
    
    for (int i = 0; i < arreglo.Length; i++) {
      
      arreglo[i] = rnd.Next(1000001);
    }
  }
  
  public void MetodoShell() {
    int salto = 0;
    int intercambio = 0;
    int auxiliar = 0;
    int e = 0;
    salto = arreglo.Length / 2;
    while (salto > 0) {
      intercambio = 1;
      while (intercambio != 0) {
        intercambio = 0;
        e = 1;
        while (e <= (arreglo.Length - salto)) { 
          if(arreglo[e-1] >arreglo[(e-1)+salto]) {
            auxiliar=arreglo[(e-1)+salto];
            arreglo[(e-1)+salto]=arreglo[e-1];
            arreglo[(e-1)]=auxiliar;
            intercambio=1;
          }
          
          e++;
        }
      }
      salto=salto/2;
    }
  }
  
  public  void mostrar() {
    Console.Write("Datos Ordenados");
    
    for (int n = 0; n < tamaño; n++) {
      Console.Write("{0} ", arreglo[n]);
    }
  }
}

class Program {
  static void Main(string[] args) {
    Shell sh = new Shell();
    sh.InsertarDatos();
    sh.MetodoShell();
    sh.mostrar();
  }
}