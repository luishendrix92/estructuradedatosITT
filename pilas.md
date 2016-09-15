# Estructuras Lineales

## Pilas

Una pila representa una estructura lineal de datos en que se puede agregar o quiter lementos C:nicamente por uno de los dos extremos. Los elementosde una pila se eliminan en orden inverso al que se insertaron. Debido a esta carateristica, se le conoce como estructura LIFO (last input, first output).

- Existen muchos casos prC!cticos en los que se utiliza la idea de pila:
- **Ejemplo**: pila de platos, en el supermercado latas.
- Las pilas son estructuras lineales como los arreglos.
- Sus componentes ocupan lugares sucesivos en la ED y c/u tienen un C:nico sucesor/predecesor, con excepciC3n del primero/C:ltimo.

![Imagen Stack](https://www.tutorialspoint.com/data_structures_algorithms/images/stack_representation.jpg)

**DefiniciC3n**: Es una colecciC3n de datos a los cuC!les se les puede acceder mediante un extremo, que se conoce generalmente como tope.

### RepresentaciC3n

- Las pilas no son estructuras fundamentales de datos.
- No estC!n definindas como tales en los lenguajes de programaciC3n.
- Para su representaciC3n requiren de otras E.D.
- Arreglos
- Listas

### TamaC1o

Es necesario e importante definir el tamaC1o mC!ximo de la pila, asC- como una variable auxiliar que se deomina TOPE. Esta variable se utiliza para indicar el C:ltimo elemento que se insertC3 en la pila. Al utilizar arreglos para implementar pilas se debe reservar el espacio en memoria con anticipaciC3n. Dado un mC!ximo de capacidad a la pila no es posible insertar un nC:mero de elementos mayor que el mC!ximo establecido.

Si la pila estC! llena y se intenta insertar un nuevo elemento, se producirC! un error conocido como desbordamiento - overflow.

> Tarea: Investigar variables auxiliares utilizadas en pilas y colas