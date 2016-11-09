using System;

class Burbuja {
  int[] arreglo;
  
  // Complejidad en el tiempo:
  // -------------------------------------------------------
  // Peor de los casos: O(n^2), ordenada en la dirección
  // opuesta. Mejor de los casos: O(n) (ya estaba ordenada).
  public void Ordenar(bool ordenado = false) {
    if (!ordenado) {
      ordenado = true;
      
      for (int i = 0; i < arreglo.Length - 1; i++) {
        // Descendente ">" -- Ascendente "<"
        if (arreglo[i + 1] < arreglo[i]) {
          Intercambiar(i, i + 1);
          ordenado = false;
        }
      }

      Ordenar(ordenado);
    }
  }
  
  public void Llenar() {
    int cant = 1000, randNum, a = 1, b = cant;
    Random rand = new Random();
    
    arreglo = new int[cant];
    
    for (int i = 0; i < cant; i++) {
      do {
        randNum = rand.Next(a, b + 1);
      } while (Array.IndexOf(arreglo, randNum) >= 0);
      
      arreglo[i] = randNum;
    }
  }
  
  public override string ToString() {
    string orden = "";
    
    foreach (int num in arreglo) {
      orden += num + ", ";
    }
    
    return orden + "FIN";
  }
  
  private void Intercambiar(int a, int b) {
    int temp = arreglo[a];
    
    arreglo[a] = arreglo[b];
    arreglo[b] = temp;
  }
}

class Programa {
  static void Main() {
    Burbuja burbuja = new Burbuja();
    
    burbuja.Llenar();
    Console.WriteLine(burbuja);
    burbuja.Ordenar();
    Console.WriteLine(burbuja);
  }
}