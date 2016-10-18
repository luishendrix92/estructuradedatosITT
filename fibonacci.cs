using System;

struct Fibonacci {
  public static int FibR(int n) {
    return (n <= 2)? 1 : FibR(n-1) + FibR(n-2);
  }
  
  public static int FibI(int n) {
    int fib = 1, ant = 1;
    
    for (int i = 0; i < n - 2; i++) {
      fib = fib + ant;
      ant = fib - ant;
    }
    
    return fib;
  }
}

class Programa {
  static void Main() {
    Console.WriteLine("Qué N-ésimo término de la secuencia quieres?");
    
    int nFib = Int32.Parse(Console.ReadLine());
    Console.WriteLine("N-ésimo términio recursivamente: {0}",
      Fibonacci.FibR(nFib));
    Console.WriteLine("N-ésimo término con iteración: {0}",
      Fibonacci.FibI(nFib));
  }
}