public class nodo {
  public int dato;
  public int siguiente;
}

public void insertar(int dato) {
  nodo P = new nodo();
  P.dato = dato;
  P.siguiente = null;

  if (COLA_ULTIMO != null) {
    COLA_ULTIMO.siguiente = P;
  }

  if (COLA_PRIMERO == null) {
    COLA_PRIMERO = P;
  }

  COLA_ULTIMO = P;
}

public int leer() {
  nodo P = COLA_PRIMERO;
  int dato;

  if (P != null) {
    dato = P.dato;
    COLA_PRIMERO = P.siguiente;
  } else {
    COLA_PRIMERO = null;
    COLA_ULTIMO = null;
    dato = -1;
  }

  return dato;
}

class Program {
  static void Main(string[] args) {
    clase_cola c = new clase_cola();
    int dato;
    int numero;

    Console.WriteLine("Guardando información en cola");
    c.COLA_PRIMERO = null;
    c.COLA_ULTIMO = null;

    for (int i = 0; i < 10; i++) {
      Console.Write("Agrega el número: ");
      numero = int.Parse(Console.ReadLine());
      c.insertar(numero);
    }

    Console.WriteLine("Leyendo información de cola");
    dato = c.leer();

    while (dato >= 0) {
      Console.Writeline(dato);
      dato = c.leer();
    }

    Console.WriteLine("Cola vacía");
    Console.Readkey();
  }
}
