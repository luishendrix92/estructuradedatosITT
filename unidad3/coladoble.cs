using System;

class ColaDoble {
  // @head -> Parte frontal: por donde salen (dequeue)
  // @tail -> Parte trasera: por donde entran (enqueue)
  string[] arreglo;
  int head1, tail1, tope1, head2, tail2, tope2;
  
  public ColaDoble(int numElementos) {
    int tamArr = numElementos;
    
    if (tamArr % 2 > 0) {
      tamArr++;      
      Console.WriteLine("Tu arreglo no puede de ser tamaño impar...");
      Console.WriteLine("El nuevo tamaño del arreglo es de: {0}", tamArr);
    }
    
    arreglo = new string[tamArr];
    tope1 = tamArr / 2 - 1;
    tope2 = tamArr - 1;
    tail1 = head1 = -1;
    tail2 = head2 = tope1;
  }
  
  public bool Llena1() { return tail1 >= tope1; }
  public bool Vacia1() { return head1 == -1; }
  
  public bool Llena2() { return tail2 >= tope2; }
  public bool Vacia2() { return head2 == tope1; }
  
  public bool Enqueue1(string dato) {
    if (!Llena1()) {
      arreglo[++tail1] = dato;
      if (tail1 == 0) head1 = 0;
      
      return true;
    } else {
      Console.WriteLine("COLA LLENA! No se insertó '{0}'", dato);
      return false;
    }
  }
  public string Dequeue1() {
    string datoEntregado;
    
    if (!Vacia1()) {
      datoEntregado = arreglo[head1];
      
      if (head1 == tail1) {
        head1 = tail1 = -1;
      } else {
        head1++;
      }
      
      return datoEntregado;
    } else {
      Console.WriteLine("La cola ya está vacía!");
      return null;
    }
  }
  
  public bool Enqueue2(string dato) {
    if (!Llena2()) {
      arreglo[++tail2] = dato;
      if (tail2 == tope1 + 1) head2 = tope1 + 1;
      
      return true;
    } else {
      Console.WriteLine("COLA LLENA! No se insertó '{0}'", dato);
      return false;
    }
  }
  public string Dequeue2() {
    string datoEntregado;
    
    if (!Vacia2()) {
      datoEntregado = arreglo[head2];
      
      if (head2 == tail2) {
        head2 = tail2 = tope1;
      } else {
        head2++;
      }
      
      return datoEntregado;
    } else {
      Console.WriteLine("La cola ya está vacía!");
      return null;
    }
  }
}

class Programa {
  public static void Main(string[] args) {
    ColaDoble cola;
    string datoNuevo, datoLeido;
    int tamaño;
    
    Console.Clear();
    Console.Write("Dame el Tamaño Del Arreglo: ");
    tamaño = Int32.Parse(Console.ReadLine());
    cola = new ColaDoble(tamaño);
    
    Titulo("\nIntroduce Los Datos de la 1era Cola:");
    do {
      datoNuevo = Console.ReadLine();
    } while (cola.Enqueue1(datoNuevo));
    
    PausaSeccion("llenar la 2nda cola");
    Titulo("Introduce Los Datos de la 2nda Cola:");
    do {
      datoNuevo = Console.ReadLine();
    } while (cola.Enqueue2(datoNuevo));
    
    PausaSeccion("leer la 1era cola");
    Titulo("Leyendo Los Datos de la 1era Cola");
    do {
      datoLeido = cola.Dequeue1();
      Console.WriteLine(datoLeido);
    } while (datoLeido != null);
    
    PausaSeccion("leer la 2nda cola");
    Titulo("Leyendo Los Datos de la 2nda Cola");
    do {
      datoLeido = cola.Dequeue2();
      Console.WriteLine(datoLeido);
    } while (datoLeido != null);
    PausaSeccion("finalizar el programa");
  }
  
  static void PausaSeccion(string info) {
    Console.Write("\nPresiona cualquier tecla para {0}...", info);
    Console.ReadKey();
    Console.Clear();
  }
  
  static void Titulo(string nombre) {
    Console.WriteLine(nombre);
    Console.WriteLine("----------------------------------------");
  }
}

/*==========================================================
@h -> head -> frente       @N -> Tamaño del arreglo
@t -> tail -> trasera      @n -> Tamaño de cada cola
@T -> tope -> límite
============================================================
COLAS LLENAS - ESTADO FINAL:
  h1 -------> t1   h2 -------> t2
[ 1 | 2 | 3 | 4 || 1 | 2 | 3 | 4 ] N = 8 -> n = 4
             T1               T2
------------------------------------------------------------
COLAS VACÍAS - ESTADO INICIAL:
 h1               h2
    [   |   |   |   ||   |   |   |   ] N = 8 -> n = 4
 t1              t2
------------------------------------------------------------
COLAS CON 3 ELEMENTOS:
      h1               h2
    [ 1 | 2 | 3 |   || 1 | 2 | 3 |   ] N = 8 -> n = 4
             t1               t2
------------------------------------------------------------
ENQUEUE Y DEQUEUE ELEMENTOS DE COLA 1:
          h1           h2
    [ 1 | 2 | 3 | 4 || 1 | 2 | 3 |   ] N = 8 -> n = 4
                 t1           t2
a) Dequeue -> 1 -> true / Avanza h1 a index 1
b) Enqueue 4 -> true / Avanza t1 a index 3 (tope1)

Se observa que se va a llenar aún sin considerar que aún nos
queda un espacio en el principio donde estaba el 1
==========================================================*/