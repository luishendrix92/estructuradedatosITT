using System;

class HashTable {
  public int tamaño = 11;
  public int[] espacios;
  public string[] datos;
  
  public HashTable() {
    this.espacios = new int[tamaño];
    this.datos  = new string[tamaño];
    
    for (int i = 0; i < tamaño; i++) {
      this.espacios[i] = -1;
      this.datos[i]  = null;
    }
  }
  
  public void Insertar(int clave, string dato) {
    int valorHash = FuncionHash(clave, espacios.Length);
    
    if (espacios[valorHash] == -1) {
      espacios[valorHash] = clave;
      this.datos[valorHash]  = dato;
    } else {
      if (espacios[valorHash] == clave) {
        this.datos[valorHash] = dato; // Reemplazar
      } else {
        int espacioSig = ReHash(valorHash, espacios.Length);
        
        while (
          espacios[espacioSig] != -1 &&
          espacios[espacioSig] != clave
        ) { // El espacio no está sin ocupar y no es la clave
          espacioSig = ReHash(espacioSig, espacios.Length);
        }
        
        if (espacios[espacioSig] == -1) {
          espacios[espacioSig] = clave;
          this.datos[espacioSig] = dato;
        } else {
          this.datos[espacioSig] = dato; // Reemplazar
        }
      }
    }
  }
  
  public int FuncionHash(int clave, int tamaño) {
    return clave % tamaño;
  }
  
  public int ReHash(int hashViejo, int tamaño) {
    return (hashViejo + 1) % tamaño;
  }
  
  public string Obtener(int clave) {
    int espacioInicial = FuncionHash(clave, espacios.Length);
    string dato = null;
    bool detener = false, encontrado = false;
    int posicion = espacioInicial;
    
    while (espacios[posicion] != -1 && !encontrado && !detener) {
      if (espacios[posicion] == clave) {
        encontrado = true;
        dato  = this.datos[posicion];
      } else {
        posicion = ReHash(posicion, espacios.Length);
        
        if (posicion == espacioInicial) detener = true;
      }
    }
    
    return dato;
  }
}

class Programa {
  static void Main() {
    HashTable hash = new HashTable();
    int buscarID = 17;
    string dato;
    
    hash.Insertar(54, "gato");
    hash.Insertar(26, "perro");
    hash.Insertar(93, "león");
    hash.Insertar(17, "tigre");
    hash.Insertar(77, "ave");
    hash.Insertar(31, "vaca");
    hash.Insertar(44, "cabra");
    hash.Insertar(55, "cerdo");
    hash.Insertar(20, "pollo");
    
    Console.WriteLine("Slots");
    Console.WriteLine("---------------------------------");
    foreach (int espacio in hash.espacios) {
      Console.Write("{0} ", (espacio == -1)? "[ ]" : espacio.ToString());
    }
    
    Console.WriteLine("\n\nData");
    Console.WriteLine("-----------------------------------");
    foreach (string leido in hash.datos) {
      Console.Write("{0} ",
        (leido == null)? "[ ]" : leido);
    }
    
    Console.WriteLine("\n\nBuscar el ID {0}", buscarID);
    Console.WriteLine("-----------------------------------");
    dato = hash.Obtener(buscarID);
    Console.WriteLine("El ID {0} resulta en: {1}",
      buscarID, (dato == null)? "[ ]" : dato);
  }
}