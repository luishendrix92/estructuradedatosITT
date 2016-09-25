using System;

// Este comment fue añadido apenas

class PilaDoble {
  private string[] arreglo;
  private int posicion1, posicion2, tope1, tope2;
  
  public int PorLlenarP1 {
    get { return tope1 - posicion1; }
  }
  
  public int PorLlenarP2 {
    get { return tope2 - posicion2; }
  }
  
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
  
  public int BuscarEnArreglo(string dato) {
    int numPila = 0, index = -1;
    
    for (int i = 0; i < tope2; i++) {
      if (dato == arreglo[i]) {
        numPila = (i >= tope1)? 2 : 1;
        index   = (numPila == 2)? i - tope1 : i;
        break; // Salir del ciclo
      }
    }
    
    if (index >= 0 && numPila > 0) {
      Console.WriteLine("Se encontró '{0}' en index #{1} de la pila {2}",
        dato, index, numPila);
    } else {
      Console.WriteLine("No se encontró '{0}' en todo el arreglo", dato);
    }
    
    return index;
  }
}

class Programa {
  static void Main() {
    Console.Write("¿De qué tamaño quieres la pila doble? ");
    int tamaño = Int32.Parse(Console.ReadLine());
    PilaDoble doble = new PilaDoble(tamaño);
    
    // Llenar ambas pilas con datos
    Console.WriteLine("\nProvee datos para la pila 1");
    LlenarPila(doble, 1);
    
    Console.WriteLine("\nProvee datos para la pila 2");
    LlenarPila(doble, 2);
    
    // Buscar un dato en todo el arreglo o pila doble
    Console.Write("\nDame un dato que quieras buscar: ");
    string dato = Console.ReadLine();
    doble.BuscarEnArreglo(dato);
  }
  
  static void LlenarPila(PilaDoble arreglo, int numPila) {
    if (numPila != 1 && numPila != 2) {
      throw new Exception("Sólo se admite pila 1 o 2 en numPila");
    }
    
    int porLlenar = (numPila == 1)?
    arreglo.PorLlenarP1 : arreglo.PorLlenarP2;
    
    for (int i = 0; i < porLlenar; i++) {
      Console.Write("Dato #{0}: ", i + 1);
      
      if (numPila == 1) {
        arreglo.Push1(Console.ReadLine());
      } else if (numPila == 2) {
        arreglo.Push2(Console.ReadLine());
      }
    }
  }
}
