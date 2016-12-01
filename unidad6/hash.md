# Búsqueda por Hashing

## ¿Qué es búsqueda?

Buscar valores en una lista es una tarea muy común; una aplicación podría requirir obtener un registro de un estudiante, una cuenta bancaria, historial crediticio o cualquier otro registro desde alguna base de datos o fuente de información lineal usando un **algoritmo de búsqueda**. Algunos de los algoritmos más comunes para esta tarea son el de búsqueda *serial*, búsqueda *binaria* y búsqueda por *hashing*. La herramienta para comparar el desempeño de los diferentes algoritmos se llama "análisis en tiempo de ejecución".

## Algoritmo Hashing

El agoritmo de *hashing* tiene un comportamiento del peor caso que es lineal para buscar un elemento pero con algunos cuidados, este algoritmo puede hacerse más rápido dramáticamente en el caso promedio. El *hashing* también hace más fácil el añadir y borrar elementos de la colección en la que se está buscando los elementos.

Suppose we want to store information about each student in a database, so that we can later retrieve information about any student simply using his/her student ID. To be specific, suppose the information about each student is an object of the following form, with the student ID stored in the key field:

Supóngase que queremos almacenar información acerca de cada estudiante en una base de datos para que después podamos requerir esa información utilizando sólo el **ID** del estudiante. Siendo más específicos, hay que suponer que la información de cada estudiante es un objeto de la siguiente forma con la ID almacenada en el campo "llave".

```csharp
struct Estudiante { 
  int llave;
  long telefono;
  string direccion;
};
```

We call each of these objects a record. Of course, there might be other information in each student record.

If student IDs are all in the range 0..99, we could store the records in an array of the following type, placing student ID k in location data[k]:

A cada uno de estos objetos les llamamos **registros**, si los IDs de los estudiantes están todos dentro del rango del 0 al 99, podemos almacenar los registros en una rreglo del siguiente tipo, poniendo la ID en la ubicación `datos[k]`:

```csharp
Estudiante datos[100];
```

El registro para un estudiante con ID `k` puede ser obtenido inmediatamente dado que conocemos que está en la ubicación siguiente: `datos[k]`.

Qué pasaría entonces si las IDs de los estudiantes no forman un **rango** como 0..99? Supóngase que sólo sabemos que habrá 100 o menos registros y que estarán distribuídos en el range de 0..9999. Podríamos usar un arreglo con 10,000 componentes pero sería **desperdiciar demasiada memoria** dado que sólo usaremos una pequeña fracción de ese arreglo. Parece que necesitamos almacenar los registros en un arreglo de 100 elelementos y usar una búsqueda serial a través de este arreglo cada que querramos buscar una ID en particular. Si fuésemos más listos, podríamos almacenar los registros en un arreglo relativamente pequeño y aún poder obtener los registros de los estudiantes por ID mucho más rápido de lo que lo haríamos con una búsqueda serial.

Para ilustrarlo mejor, hagamos de cuenta que sabemos que las IDs serán:

> 0, 100, 200, ... , 9800, 9900

En este caso, podemos almacenar los registros en una arreglo llamado `datos` que sólo contendrá 100 elelementos. Almacenaremos los registros con cada ID de estudiante en la ubicación `datos[k / 100]`.

**Nota:** Se está usando división entera, por lo tanto `/` regresa el cociente. Si quisiéramos obtener la información del estudiante con ID 700, haríamos la operación `700/100` para obtener el índice 7, por tanto se dice que el registro del estudiante con ID 700 se almacena en el arreglo `datos[7]`.

Esta técnica general se llama *hashing*. Cada registro requiere una clave única. En este ejemplo, la ID del estudiante es la clave única pero otras llaves más complejas son usadas a veces. Una función de hashing, mapea las llaves con los índices del arreglo donde se almacenan los registros.

## Colisiones de Índice

Supóngase que ya no queremos una ID de 400, pero tenemos una 399. El registro del estudiante 300 será almacenado en `datos[3]` como antes, pero ¿En dónde será almacenado el ID 399? El ID 399 se hashea en `datos[399/100] = datos[3]`. Ahora hay dos registros diferentes que pertenecen en `datos[3]`. A esta situación se le conoce como **colisión**.

En este caso, podríamos redefinir la función de hash para evitar la colisión pero en la prácticano sabrás qué números exactos podrán ocurrir cono llaves, por lo tanto, no puedes diseñar una función hash que esté libre de colisiones. Típicamente, tienes una ventaja de cuántas llaves vas a tener.

## La solución

The usual approach is to use an array size that is larger than needed. The extra array positions make the collisions less likely. A good hash function will distribute the keys uniformly throughout the locations of the array. If the array indices range from 0 to 99, then you might use the following hash function to produce an array index for a record with a given key:

La estrategia usual sería usar un tamaño de arreglo que es más grande del que se necesita. Esas posiciones extra del arreglo hacen que las colisiones sean menos probables. Una buena función hash distribuirá las llaves de una manera uniforme a través de las ubicaciones del arreglo. Si los índices del arreglo están entre el 0 y 99, entonces podrías usar la siguiente función hash para generar un índice para un registro con una llave dada:

```csharp
hash(k) = k % 100
```

Esta función hash siempre producirá un valor entre 0 y 99.

## Direccionamiento Libre

Una forma de solucionar las colisiones es colocar el registro colisionante en otra ubicación que aún esté libre. Este algoritmo llamado **"Direccionamiento Abierto (o Libre)"** requiere que el arreglo sea inicializado dado que el programa pueda probar si la posición ya contiene un registro. Con este método de solucionar colisiones, aún debemos decidir cómo elegir las ubicaciones para buscar una posición libre cuando ocurre una colisión. Hay dos formas principales de hacerlo.

### 1. Sondaje Lineal

Por cada registro con llave dado por llave, calcular el índice `hash(llave)`. Si `datos[hash(llave)]` no contiene un registro aún, entonces almacenarlo en ese preciso lugar y finalizar el algoritmo. Si sucede que esa ubicación ya contiene un registro, intentar con `datos[hash(llave) + 2]` y así sucesivamente hasta que se encuentre una posición vacante. Cuando se alcanza la posición máxima del arreglo, simplemente ir al inicio del arreglo. Por ejemplo, si los índices del arreglo van de 0..99, y el 98 es la llave, entonces intentar con 98, 99, 0, 1 y continuando en se orden. Buscar una posición vacante de esta forma se llama "sondaje lineal".

### 2. Doble Hashing

Hay un problema con el sondaje lineal. Cuando varias llaves diferentes mapean a la misma ubicación, el resultado es una agrupación de elementos, uno después del otro. Mientras la tabla de hashes se aproxima a su máxima capacidad, estos grupos tienden a combinarse en grupos más y más grandes. El agrupamiento hace que las inserciones tomen más tiempo porque la función de insertar debe brincar grupos para encontrar una ubicación vacante. Las búsquedas requieren más tiempo por la misma razón. La técnica más común para evitar el agrupamiento se llama **doble hashing**. Reemplaza el paso 3 en el algoritmo anterior con el siguiente paso:

Hacer que `i = hash(llave)`. Si la ubicación `datos[i]` ya contiene un registro entonces `i = (i + hash2(llave)) % TAMAÑO` y pruba el nuevo `datos[i]`. Si esa ubicación también contiene un registro entonces `i = (i + hash2(llave)) % TAMAÑO` de nuevo en repetidas ocasiones hasta que se encuentre una vacante.

**Nota Importante:** Con un doble hashing, podemos regresar a nuestra posición inicial antes de examinar cada ubicación disponible. Una forma de prevenir esto es asegurarnos que el tamaño del arreglo sea relativamente primo con respecto al valor devuelto por `hash2()` o, en otras palabras, esos dos números no deben tener un factor común aparte del 1.`hash2(llave)` debe retornar un valor en el rango de **1 hasta [TAMAÑO - 1]**. Dos posibles implementaciones serían:

1. `hash2(llave) = 1 + (llave % (TAMAÑO - 2)`
2. `hash2(llave) = max(1, (llave / TAMAÑO) % TAMAÑO)`

## Hashing Enlazado

En el direccionamiento abierto, cada elemento del arreglo puede almacenar sólo un registro. Cuando el arreglo está lleno, ya no se pueden añadir más registros a la tabla. Una posible solución es redimensionar el arreglo y re-hashear todas las entradas de éste; requeriría una cuidadosa elección de un nuevo tamaño y probablemente requiera que cada entrada tenga un nuevo hash calculado.

Un acercamiento más viable és utilizar un método diferente de solución de colisiones llamado **hashing enlazado**, o simplemente enlazado, en el que cada componente de tabla puede almacenar más de un registro. Aún tenemos que hashear cada llave de cada registro, pero cuando ocurre una colisión, simplemente ponemos el nuevo registro en su componente apropiado del arreglo junto con otras entradas que cayeron en el **mismo índice**. La forma más común de implementar el hashing enlazado es hacer que cada elemento del arreglo sea una lista enlazada. Los nodos en una lista enlazada particular tendrían una llave que hashearían al mismo valor.

## Run-Time Analysis del Hashing

En el peor de los casos, cuando cada llave hashea hacia el mismo índice del arreglo, podemos terminar buscando a través de todos los registros para buscar el elemento tal cual lo haríamos en una búsqueda secuencial. El caso promedio en performance es complejo, particularmente si se permite el borrado de registros.

> Fuente: Jonathan Alon <jalon@cs.bu.edu>. Material adaptado del libro "Data Structures and Other Objects Using C++", by Main and Savitch.