using System;

class Opns {
	public static int Factorial(int n) {
		int resultado = 1;
		
		for (int i = 2; i <= n; i++) {
            resultado *= i;
        }
        
        return resultado;
	}
	
	public static int Combinatoria(int n, int r) {
		// Combinatoria sin repetición
		// nCr = n! / r!(n - r)!
		if (r > n || r < 0 || n < 0) {
			throw new Exception("N o R son parámetros inválidos de combinatoria");
		}
		
		return Factorial(n) / (Factorial(r) * Factorial(n - r));
	}
	
	public static int Permutar(int n, int r) {
		// Permutación sin repetición => n!
		if (n < 0) throw new Exception("Imposible calcular factorial negativo");
		
		return Factorial(n) / Factorial(n - r);
	}
}

class Programa {
	public static void Main (string[] args) {
		int nPermutar, nComb, rComb, rPermutar;
		
		Console.WriteLine("Permutaciones de n elementos en r. Dámelos:");
		nPermutar = Int32.Parse(Console.ReadLine());
		rPermutar = Int32.Parse(Console.ReadLine());
		Console.WriteLine("{0} permutaciones de {1} items en {2} espacios.",
			Opns.Permutar(nPermutar, rPermutar), nPermutar, rPermutar);
    
		Console.WriteLine("Combinaciones de 'n' en 'r'. Dámelos en ese orden:");
		nComb = Int32.Parse(Console.ReadLine());
		rComb = Int32.Parse(Console.ReadLine());
		Console.WriteLine("{0} combinaciones de {1} ({0}C{1}) son {2}.",
			nComb, rComb, Opns.Combinatoria(nComb, rComb));
	}
}
