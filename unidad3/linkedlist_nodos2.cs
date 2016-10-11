using System;

class Nodo {
	public int dato;
	public Nodo siguiente;
	
	public Nodo(int _dato, Nodo _sig) {
		dato = _dato; siguiente = _sig;
	}
}

class Lista {
	public Nodo inicio;
	
	public Lista() { inicio = null; }
	
	public void InsertarPorFinal(int _dato) {
		Nodo auxiliar = new Nodo(_dato, null);
		
		if (inicio == null) {
			inicio = auxiliar;
		} else {
			Nodo puntero = inicio;
			
			while (puntero.siguiente != null) {
				puntero = puntero.siguiente;
			}
			
			puntero.siguiente = auxiliar;
		}
	}
	
	public void EliminarPorFinal() {
		if (inicio == null) {
			Console.WriteLine("La lista está vacía");
		} else {
			if (inicio.siguiente == null) {
				inicio = null;
			} else {
				Nodo punteroAnterior, punteroSiguiente;
				punteroAnterior = punteroSiguiente = inicio;
				
				while (punteroSiguiente.siguiente != null) {
					punteroAnterior = punteroSiguiente;
					punteroSiguiente = punteroSiguiente.siguiente;
				}
				
				punteroAnterior.siguiente = null;
			}
		}
	}
	
	public void InsertarPorInicio(int _dato) {
		Nodo auxiliar = new Nodo(_dato, null);
		
		if (inicio == null) {
			inicio = auxiliar;
		} else {
			Nodo puntero = inicio;
			inicio = auxiliar;
			auxiliar.siguiente = puntero;
		}
	}
	
	public void EliminarPorInicio() {
		if (inicio == null) {
			Console.WriteLine("La lista está vacía");
		} else {
			inicio = inicio.siguiente;
		}
	}
	
	public void InsertarPosicion(int _dato, int posicion) {
		Nodo auxiliar = new Nodo(_dato, null);
		
		if (inicio == null) {
			Console.WriteLine("Lista vacía, el dato se agrega en la pos. 1");
			inicio = auxiliar;
		} else {
			Nodo puntero = inicio;
			
			if (posicion == 1) {
				inicio = auxiliar;
				auxiliar.siguiente = puntero;
			} else {
				for (int i = 1; i < posicion - 1; i++) {
					puntero = puntero.siguiente;
					
					if (puntero.siguiente == null) {
						break;
					}
				}
				
				Nodo punteroSiguiente = puntero.siguiente;
				puntero.siguiente = auxiliar;
				auxiliar.siguiente = punteroSiguiente;
			}
		}
	}
	
	public void Mostrar() {
		if (inicio == null) {
			Console.WriteLine("La lista está vacía");
		} else {
			Nodo puntero = inicio;
			
			Console.WriteLine(puntero.dato);
			
			while (puntero.siguiente != null) {
				puntero = puntero.siguiente;
				Console.WriteLine(puntero.dato);
			}
		}
	}
}

class Programa {
	static void Main() {
		Lista L = new Lista();
		
		L.InsertarPorFinal(10);
		L.InsertarPorFinal(15);
		L.InsertarPorFinal(12);
		L.InsertarPorFinal(14);
		L.InsertarPorFinal(1);
		
		L.Mostrar();
		
		Console.Read();
		//Console.Write("\nPresione cualquier tecla para continuar... ");
		//Console.Clear();
		
		L.InsertarPosicion(18, 4);
		L.Mostrar();
	}
}

/*
{5 -}-> {7 -}-> {9 -}-> {11 -}-> null

Insertar(9):
  1- Actual = 5; 9 es mayor que 5, entonces:
    Actual = 7 -> Siguiente iteración de WHILE
  2- 
*/
