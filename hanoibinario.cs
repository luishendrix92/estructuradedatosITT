using System;

class Programa {
	static void hanoi(int discos) {
		// Cantidad de movimientos 2^n - 1
		int movimientos = 1 << discos;
		
		for (int mov = 1; mov < movimientos; mov++) {
			int desde = (mov & mov - 1) % 3;
			int hacia = ((mov | mov - 1) + 1) % 3;
			
			Console.WriteLine("Mueve el disco de la torre {0} a la torre {1}",
				desde + 1, hacia + 1);
		}
	}
	
	static void Main() {
		int discos;
		
		Console.WriteLine("De cuántos discos quieres el juego?");
		discos = Int32.Parse(Console.ReadLine());
		
		hanoi(discos);
	}
}
