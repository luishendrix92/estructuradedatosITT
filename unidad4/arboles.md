# Árboles

Estructura no lineal formada por un conjunto de nodos y un conjunto de ramas. Existe un nodo especial (**raíz**), aquel nodo que sale de alguna rama se le llama Nodo de bifurcación o Nodo **rama**.

Nodo que no tiene ramas se le llama Nodo terminal o Nodo **hoja**.

![ilustrado](http://sourcecodemania.com/wp-content/uploads/2012/05/tree-general.jpg)

En pocas palabras, un árbol es un conjunto finito de uno o más nodos. Nodos restantes: N > 0. 

## Árbol Binario

Un árbol binario es una estructura de datos de tipo árbol en donde cada uno de los nodos del árbol puede tener **0, 1 o 2 sub-árboles.** Si el nodo raíz tiene 0 relaciones, se llama hoja. Si el nodo raíz tiene una relación a la izquierda, el segundo elemento de la relación es el sub-árbol izquierdo. Si el nodo raíz tiene una relación a la derecha, entonces el segundo elemento de la relación es el sub-árbol derecho.

- **Grados**: Hace referencia a la cantidad de hijosque tiene el nodo.
- **Orden**: Hace referencia al numero potencial de hijos que puede tener cada elemento del árbol.

> Un árbol binario es de orden 2.

![binario](https://upload.wikimedia.org/wikipedia/commons/6/67/Sorted_binary_tree.svg)

### Tipos de Árbol Binario

- Distintos
- Similares
- Equivalentes
- Completos

#### Árbol Binario Distinto

Se dice que dos árboles binarios son distintos cuando sus estructuras son diferentes.

![dist](http://www.gayatlacomulco.com/tutorials/estru1/631.gif)

#### Árbol Binario Similar

Dos árboles binarios son similares cuando sus estructuras son idénticas, pero la información que contienen sus nodos es diferente.

![sim](http://www.gayatlacomulco.com/tutorials/estru1/632.gif)

#### Árbol Binario Equivalente

Son aquellos árboles que son similares y que además los nodos contienen la misma información.

![equiv](http://www.monografias.com/trabajos92/arboles-binario/image005.gif)

#### Árbol Binario Completo

Son aquellos árboles en los que todos sus nodos excepto los del último nivel tienen dos hijos: el sub-árbol izquierdo y el sub-árbol derecho.

![comp](http://www.sites.upiicsa.ipn.mx/polilibros/portal/polilibros/p_terminados/EstrRepreDat/Files/arbol2.jpg)

#### Árbol Binario de Búsqueda

Es un árbol binario con la propiedad que todos los elementos almacenados en el sub-árbol izquierdo de cualquier nodo **x** son menores al elemento almacenado **x**. Todos los elementos almacenados en el sub-árbol derecho de **x** son mayores al elemento almacenado **x**.

![Search](https://encrypt3d.files.wordpress.com/2010/09/nodes-in-binary-search-tree.png)

## Operaciones Básicas en los Árboles

- Añadir o insertar elementos
- Buscar o localizar elementos
- Borrar elementos
- Moverse a través de árbol
- Recorrere el árbol completo

## Recorrido de un Árbol

- Pre-orden
- In-orden
- Post-orden

### Pre-Orden

- Nodo raiz
- Sub-árbol izquierdo
- Sub-árbol derecho

### In-Orden

- Sub-árbol izquierdo
- Nodo raiz
- Sub-árbol derecho

### Post-Orden

- Sub-árbol izquierdo
- Sub-árbol derecho
- Nodo raiz
