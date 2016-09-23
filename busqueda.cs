using System;

class Pila {
  string[] dato;
  int posicion, tope;
  
  public Pila(int tamaño) {
    dato     = new string[tamaño];
    tope     = tamaño;
    posicion = 0;
  }
  
  public void Push(string ndato) {
    if (posicion == tope) {
      Console.WriteLine("La pila ya está llena");
    } else {
      dato[posicion] = ndato;
			posicion++;
    }
  }
  
  public string Pop() {
    if (posicion <= 0) {
			Console.WriteLine("La pila 1 está vacía");
			return null;
		} else {
			posicion--;
			return dato[posicion];
		}
  }
  
  public void busqueda(string ndato) {
    bool encontrado = false;
    int i = 0;
    
    while (i < tope && !encontrado) {
      if (ndato == dato[i]) {
        Console.WriteLine("Se encontró '{0}' en index {1}", ndato, i);
        encontrado = true;
      } else {
        i++;
      }
    }
    
    if (!encontrado) Console.WriteLine("No se encontró '{0}'", ndato);
  }
}

class Programa {  
  static void Main() {
    Pila p = new Pila(6);
    
    Console.WriteLine("Dame 6 cadenas de texto:");
    
    for (int i = 0; i < 6; i ++) {
      p.Push(Console.ReadLine());
    }
    
    p.busqueda("hola");
  }
}