using System;
using System.Collections.Generic;
using System.Text;

class Mergesort {
  public static void MergeSort(int[] numeros, int izq, int medio, int der) {
    int[] temp = new int[der * 2];
    int i, izqFin, cantNums, posTemp;
    
    izqFin   = medio - 1;
    posTemp  = izq;
    cantNums = der - izq + 1;
    
    while ((izq <= izqFin) && (medio <= der)) {
      if (numeros[izq] <= numeros[medio]) {
        temp[posTemp++] = numeros[izq++];
      } else {
        temp[posTemp++] = numeros[medio++];
      }
    }
    
    while (izq <= izqFin) {
      temp[posTemp++] = numeros[izq++];
    }
    
    while (medio <= der) {
      temp[posTemp++] = numeros[medio++];
    }
    
    for (i = 0; i < cantNums; i++) {
      numeros[der] = temp[der];
      der--;
    }
  }
  
  public static void MSRecursivo(int[] numeros, int izq, int der) {
    int medio;
    
    if (der > izq) {
      medio = (der + izq) / 2;
      MSRecursivo(numeros, izq, medio);
      MSRecursivo(numeros, (medio + 1), der);
      
      MergeSort(numeros, izq, (medio + 1), der);
    }
  }
}

class Programa {
  static void Main() {
    int cant = 250, randNum, a = 1, b = cant;
    Random rand   = new Random();
    int[] arreglo = new int[cant];
    
    for (int i = 0; i < cant; i++) {
      do {
        randNum = rand.Next(a, b + 1);
      } while (Array.IndexOf(arreglo, randNum) >= 0);
      
      arreglo[i] = randNum;
    }
    
    Mergesort.MSRecursivo(arreglo, 0, arreglo.Length - 1);
    
    foreach (int num in arreglo) {
      Console.Write("{0} -> ", num);
    }
  }
}