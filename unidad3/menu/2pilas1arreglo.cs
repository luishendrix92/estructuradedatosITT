using System;

/*//////////////////////////////////////////////////////
@t = Topes donde t1 es tope1 y t2 es tope2
@p = Posiciones donde p1 es posicion1 y p2 es posicion2
@s = stack / pila completa | @i = index / índice
////////////////////////////////////////////////////////
Ilustración de la pila con tamaños pares:

t  ->                  .--->t1            .--->t2
p  ->    p1<----------'     p2<----------'
s  -> [ "1" | "2" | "3" || "4" | "5" | "6" ||____] N = 6
i  ->    0     1     2      3     4     5     _6

Ilustración de la pila con tamaños pares:

t  ->            .--->t1            .--->t2
p  ->    p1<----'     p2<----------'
s  -> [ "1" | "2" || "3" | "4" | "5" ||____] N = 5
i  ->    0     1     2      3     4     _5
//////////////////////////////////////////////////////*/

namespace Unidad3 {
  class PilaDoble {
    private string[] arreglo;
    private int posicion1, posicion2, tope1, tope2;
    
    public PilaDoble(int tamaño) {
      posicion1 = 0;
      tope1     = tamaño / 2;
      posicion2 = tamaño / 2;
      tope2     = tamaño;
      arreglo   = new string[tamaño];
    }
    
    public void Push1(string dato) {
      if (posicion1 == tope1) {
        Console.WriteLine(
          "No se pudo insertar '{0}' - La pila 1 ya está llena",
        dato);
      } else {
        arreglo[posicion1] = dato;
        posicion1++;
      }
    }
    
    public void Push2(string dato) {
      if (posicion2 == tope2) {
        Console.WriteLine(
          "No se pudo insertar '{0}' - La pila 2 ya está llena",
        dato);
      } else {
        arreglo[posicion2] = dato;
        posicion2++;
      }
    }
    
    public string Pop1() {
      if (posicion1 <= 0) {
        Console.WriteLine("La pila 1 está vacía");
        return null;
      } else {
        posicion1--;
        return arreglo[posicion1];
      }
    }
    
    public string Pop2() {
      if (posicion2 <= tope1) {
        Console.WriteLine("La pila 2 está vacía");
        return null;
      } else {
        posicion2--;
        return arreglo[posicion2];
      }
    }
  }

  class Practica4 {  
    public static void Mostrar() {
      int TAM_ARR_IMPAR, TAM_ARR_PAR;
      PilaDoble arrPar, arrImpar;
      
      // Decidiendo el tamaño de los arreglos de pila
      Console.Clear();
      Console.WriteLine("Dame el tamaño del arreglo PAR:");
      TAM_ARR_PAR = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Dame el tamaño del arreglo IMPAR:");
      TAM_ARR_IMPAR = Int32.Parse(Console.ReadLine());
      
      arrPar   = new PilaDoble(TAM_ARR_PAR);
      arrImpar = new PilaDoble(TAM_ARR_IMPAR);
      
      // Manejo de un arreglo con tamaño PAR
      Console.WriteLine("Provee datos para la pila 1 (arreglo par)");
      LlenarPila(arrPar, TAM_ARR_PAR / 2, 1);
      
      Console.WriteLine("\nProvee datos para la pila 2 (arreglo par)");
      LlenarPila(arrPar, TAM_ARR_PAR / 2, 2);
      
      Console.WriteLine("\nÉstos son los contenidos de la pila 1 (par):");
      VaciarPila(arrPar, 1);
      
      Console.WriteLine("\nÉstos son los contenidos de la pila 2 (par):");
      VaciarPila(arrPar, 2);
      
      // Manejo de un arreglo con tamaño IMPAR
      Console.WriteLine("\n----------------------------------------------");
      Console.WriteLine("\nProvee datos para la pila 1 (arreglo impar)");
      LlenarPila(arrImpar, TAM_ARR_IMPAR / 2, 1);
      
      Console.WriteLine("\nProvee datos para la pila 2 (arreglo impar)");
      LlenarPila(arrImpar, (TAM_ARR_IMPAR / 2) + 1, 2);
      
      Console.WriteLine("\nÉstos son los contenidos de la pila 1 (impar):");
      VaciarPila(arrImpar, 1);
      
      Console.WriteLine("\nÉstos son los contenidos de la pila 2 (impar):");
      VaciarPila(arrImpar, 2);
      
      Console.WriteLine("\nPRESIONE CUALQUIER TECLA PARA VOLVER AL MENÚ...");
      Console.ReadKey();
    }
    
    static void LlenarPila(PilaDoble arreglo, int numDatos, int numPila) {
      string nuevoDato;
      
      for (int i = 0; i < numDatos + 1; i++) {
        nuevoDato = Console.ReadLine();
        
        if (numPila == 1) {
          arreglo.Push1(nuevoDato);
        } else if (numPila == 2) {
          arreglo.Push2(nuevoDato);
        } else {
          throw new Exception("Sólo se admite pila #1 o pila #2 en numPila");
        }
      }
    }
    
    static void VaciarPila(PilaDoble arreglo, int numPila) {
      string datoLeido;
      bool pilaVacia;
      
      do {
        if (numPila == 1) {
          datoLeido = arreglo.Pop1();
        } else if (numPila == 2) {
          datoLeido = arreglo.Pop2();
        } else {
          throw new Exception("Sólo se admite pila #1 o pila #2 en numPila");
        }
        
        pilaVacia = datoLeido == null;
        
        if (!pilaVacia) Console.WriteLine(datoLeido);
      } while (!pilaVacia);
    }
  }
}