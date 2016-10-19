using System;

class Program {
  static void Main(string[] args) {
    int[] numbers = new int[10];
    Random rand = new Random();
    int numRandom;
    
    for (int i = 0; i < 10; i++) {
      do {
      	numRandom = rand.Next(1, 11);
      } while (Array.IndexOf(numbers, numRandom) >= 0);
      
      numbers[i] = numRandom;
    }
 
    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Number of the array on index [{0}]: {1}.", i, numbers[i]);
    }
  }
}