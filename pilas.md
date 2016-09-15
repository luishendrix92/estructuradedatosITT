# Estructuras Lineales

## Pilas

Una pila representa una estructura lineal de datos en que se puede agregar o quiter lementos únicamente por uno de los dos extremos. Los elementosde una pila se eliminan en orden inverso al que se insertaron. Debido a esta carateristica, se le conoce como estructura LIFO (last input, first output).

- Existen muchos casos prácticos en los que se utiliza la idea de pila:
- **Ejemplo**: pila de platos, en el supermercado latas.
- Las pilas son estructuras lineales como los arreglos.
- Sus componentes ocupan lugares sucesivos en la ED y c/u tienen un único sucesor/predecesor, con excepción del primero/último.

![Imagen Stack](https://www.tutorialspoint.com/data_structures_algorithms/images/stack_representation.jpg)

**Definición**: Es una colección de datos a los cuáles se les puede acceder mediante un extremo, que se conoce generalmente como tope.

### Representación

- Las pilas no son estructuras fundamentales de datos.
- No están definindas como tales en los lenguajes de programación.
- Para su representación requiren de otras E.D.
- Arreglos
- Listas

### Tamaño

Es necesario e importante definir el tamaño máximo de la pila, así como una variable auxiliar que se deomina TOPE. Esta variable se utiliza para indicar el último elemento que se insertó en la pila. Al utilizar arreglos para implementar pilas se debe reservar el espacio en memoria con anticipación. Dado un máximo de capacidad a la pila no es posible insertar un número de elementos mayor que el máximo establecido.

Si la pila está llena y se intenta insertar un nuevo elemento, se producirá un error conocido como desbordamiento - overflow.
