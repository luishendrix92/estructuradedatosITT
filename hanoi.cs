using System;

class TorreDeHanoi {
  public int discos;
  public string origen, auxiliar, destino;

  public int MinimoDeMovimientos {
    get { return (int) Math.Pow(2, discos) - 1; }
  } // Fórmula "M = 2^n - 1" donde "n" son los discos

  public TorreDeHanoi
  (int n = 3, string o = "1", string a = "2", string d = "3") {
    discos   = n; origen   = o;
    auxiliar = a; destino  = d;
  } // Fin de constructor con valores default

  /* PASO #2: Mover el disco que quedó en el
  || origen hacia el destino definido o torre #3
  \\==========================================*/
  public static void MoverDiscos
  (int discos, string origen, string aux, string destino) {
    // Hay discos para mover? Moverlos, si no, termina recursión
    if (discos > 0) {
      
      /* PASO #1: Mover los discos de arriba (discos - 1)
      || desde el inicio hacia la torre auxiliar.
      \\===============================================*/
      MoverDiscos(discos - 1, origen, destino, aux);

      // Imprimir el movimiento que acabamos de hacer
      Console.WriteLine("Mueve el disco {0} de la torre {1} a la torre {2}",
        discos, origen, destino);

      /* PASO #3: Mover los discos que quedaron en la
      || torre auxiliar hacia el destino (discos - 1)
      \============================================*/
      MoverDiscos(discos - 1, aux, origen, destino);
    } // Fin de comprobar si quedan discos por mover
  } // Fin de proceso recursivo para resolver la torre

  public void MostrarSolucion()
  { TorreDeHanoi.MoverDiscos(discos, origen, auxiliar, destino); }
} // Fin de la clase de Torre de Hanoi

class Programa {
  static void Main() {
    Console.WriteLine("De cuántos discos quieres el juego?");
    int numDiscos      = Int32.Parse(Console.ReadLine());
    TorreDeHanoi torre = new TorreDeHanoi(numDiscos, "A", "B", "C");

    Console.WriteLine("Este juego será resuelto en mínimo {0} movimientos",
      torre.MinimoDeMovimientos);
    torre.MostrarSolucion();
  } // Fin de método principal
} // Fin de clase programa