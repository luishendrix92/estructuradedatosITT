using System;

class Intercalacion_Simple {
  public int[] arregloA, arregloB;
  int[] arregloC, TemporalA, TemporalB;
  // Los arreglos temporales son de referencia para estar generando
  // cuantas veces quieras la cantidad de numeros aleatorios
  int N = 10, M = 10, i, j, x, w, I, J, K, X;
  
  public Intercalacion_Simple() {
    arregloA  = new int[N];
    arregloB  = new int[M];
    arregloC  = new int[arregloA.Length + arregloB.Length];
    TemporalA = new int[arregloA.Length];
    TemporalB = new int[arregloB.Length];
  }
  
  public void Generar() {
    // Una vez generados los numeros aleatorios se asignan a los
    // arreglos fijos sobre los cuales se debe trabajar el ordenamiento
    Random Aleatorio = new Random();
    int max = 100;
    
    for (int i = 0; i < N; i++) {
      arregloA[i] = Aleatorio.Next(1, max + 1);
      TemporalA[i] = arregloA[i];
    }
    
    for (int i = 0; i < M; i++) {
      arregloB[i] = Aleatorio.Next(1, max + 1);
      TemporalB[i] = arregloB[i];
    }
  }
  
  // Los metodos de ordenamiento utilizados para los arreglos son quicksort
  public void quicksortA(int L, int R) {
    i = L;
    j = R;
    x = arregloA[(L + R) / 2];
    
    do {
      while (arregloA[i] < x) i = i + 1;
      while (x < arregloA[j]) j = j - 1;
      
      if (i <= j) {
        w = arregloA[i];
        arregloA[i] = arregloA[j];
        arregloA[j] = w;
        i = i + 1;
        j = j - 1;
      }
    } while (i < j);
    
    if (L < j) quicksortA(L, j);
    if (i < R) quicksortA(i, R);
  }
  
  public void quicksortB(int L, int R) {
    i = L;
    j = R;
    x = arregloB[(L + R) / 2];
    
    do {
      while (arregloB[i] < x) i = i + 1;
      while (x < arregloB[j]) j = j - 1;
      
      if (i <= j) {
        w = arregloB[i];
        arregloB[i] = arregloB[j];
        arregloB[j] = w;
        i = i + 1;
        j = j - 1;
      }
    } while (i < j);
    
    if (L < j) quicksortB(L, j);    
    if (i < R) quicksortB(i, R);
  }
  
  public void Intercalar() {
    I = 0;
    J = 0;
    K = 0;
    X = 0;
    
    while (I < N && J < M) {
      if (arregloA[I] <= arregloB[J]) {
        arregloC[K] = arregloA[I];
        I = I + 1;
        K = K + 1;
      } else {
        arregloC[K] = arregloB[J];
        J = J + 1;
        K = K + 1;
      }
    }
    
    if (I > N) {
      for (X = J; X < M; X++) {
        arregloC[K] = arregloB[X];
        K = K + 1;
      }
    } else {
      for (X = I; X < N; X++) {
        arregloC[K] = arregloA[X];
        K = K + 1;
      }
    }
  }
  
  public void DesplegarDesordenA() {
    int Cont = 1;
    
    Console.Write("Arreglo A\n\n");
    
    for (int i = 0; i < TemporalA.Length; i++) {
      Console.Write("{0}: {1}\t\t", i + 1, TemporalA[i]);
      
      if (Cont == 5) {
        Console.Write("\n\n");
        Cont = 0;
      }
      
      Cont++;
    }
  }
  
  public void DesplegarDesordenB() {
    int Cont = 1;
    
    Console.Write("\nArreglo B\n\n");
    
    for (int i = 0; i < TemporalB.Length; i++) {
      
      Console.Write("{0}: {1}\t\t", i + 1, TemporalB[i]);
      
      if (Cont == 5) {
        Console.Write("\n\n");
        Cont = 0;
      }
      
      Cont++;
    }
  }
  
  public void DesplegarOrdenA() {
    int Cont = 1;
    
    Console.Write("Arreglo A\n\n");
    
    for (int i = 0; i < arregloA.Length; i++) {
      Console.Write("{0}: {1}\t\t", i + 1, arregloA[i]);
      
      if (Cont == 5) {
        Console.Write("\n\n");
        Cont = 0;
      }
      
      Cont++;
    }
  }
  
  public void DesplegarOrdenB() {
    int Cont = 1;
    
    Console.Write("\nArreglo B\n\n");
    
    for (int i = 0; i < arregloB.Length; i++) {
      Console.Write("{0}: {1}\t\t", i + 1, arregloB[i]);
      
      if (Cont == 5) {
        Console.Write("\n\n");
        Cont = 0;
      }
      
      Cont++;
    }
  }
  
  public void DesplegarIntercalado() {
    int Cont = 1;
    
    for (int i = 0; i < arregloC.Length; i++) {
      Console.Write("{0}: {1}\t\t", i + 1, arregloC[i]);
      
      if (Cont == 5) {
        Console.Write("\n\n");
        Cont = 0;
      }
      
      Cont++;
    }
  }
}

class Program {
  static void Main(string[] args) {
    Intercalacion_Simple inter= new Intercalacion_Simple();
    inter.Generar();
    
    Console.WriteLine("Arreglos Desordenados\n");
    inter.DesplegarDesordenA();
    inter.DesplegarDesordenB();
    inter.quicksortA(0, inter.arregloA.Length - 1);
    inter.quicksortB(0, inter.arregloB.Length - 1);
    
    Console.WriteLine("Arreglos Ordenados\n");
    inter.DesplegarOrdenA();
    inter.DesplegarOrdenB();
    
    Console.WriteLine("Ordenamiento de los dos vectores intercalados\n");
    inter.Intercalar();
    inter.DesplegarIntercalado();
  }
}
