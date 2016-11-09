# Definiciones

### Definición 1

Un grafo se define como un par G = (V, A), donde V es un conjunto finito no vacío de vértices y A es un conjunto de pares de vértices de V, es decir, las aristas.

### Definición 2

Un grafo G se define como un par ordenado, G = (V, A), donde V es un conjunto finito y A es un conjunto que consta de dos elementos de V.

## Grafos dirigidos y no dirigidos

Dependiendo del tipo de relación entre los vértices del grafo, se definen distintos de grafos. Así se distinguen las aristas dirigidas y no dirigidas:

- **Arista dirigida**: es aquella que define un par ordenado de vértices (u, v), donde el primer vértice es el origen de la arista y el segundo vértice v es el ermino (o vértice final). El par (u, v) DIFF (v, u).

- **Arista no dirigida**: es aquella que define un par no ordenado de vértices (u, v), donde (u, v) = (v, u).

- **Grafo dirigido**: Es aquel cuyas aristas son dirigidas. Los grafos dirigidos suelen representar relaciones asimétricas como por ejemplo: relaciones de herencia o los vuelos entre ciudades.

- **Grafo no dirigido**: Es aquel cuyas aristas son no dirigidas. Representan relaciones simétricas como relaciones de hermandad y colaboración, conexiones de transportes, etc.

- **Adyacencia**: Dos vértices *u* y *v* son adyacentes si existe una arista cuyos vértices sean *u* y *v*.

- El vértice *u* es adyacente a *v*
- El vértice *v* es adyacene desde *u*

- **Grado**: El grado de un vértice u es el número de vértices adyacentes a u. Para un grafo dirigido, el grado de salida de un vértice u es el número de vértices adyancentes desde u, mientras que el grado de entrada de un vértice u es el número de vértices adyancentes a u.

#### Grafo no dirigido

|  Vértice  | Grado |
|-----------|-------|
| Grado (a) |   3   |
| Grado (b) |   3   |
| Grado (c) |   2   |
| Grado (d) |   4   |
| Grado (e) |   4   |

#### Grafo dirigido

|  Vértice   | Grado |
|------------|-------|
| GradoE (a) |   2   |
| GradoE (b) |   3   |
| GradoE (c) |   0   |
| GradoE (d) |   2   |
| GradoE (e) |   1   |

|  Vértice   | Grado |
|------------|-------|
| GradoS (a) |   1   |
| GradoS (b) |   0   |
| GradoS (c) |   2   |
| GradoS (d) |   2   |
| GradoS (e) |   3   |

## Grafo simple y multigrafo

Un grafo simple es aquel que no tiene aristas paralelas o múltiples que unan el mismo par de vértices. Un grafo que cuente con múltiples aristas entre dos vértices se denomina multigrafo.

## Camino, bucle, ciclo

Un camino es una secuencia que alterna vértices y aristas que comienza por un vértice y termina en vértice tal que cada arista es incidente a su vértice predecesor y sucesor.

Un camino es simple si cada vértice en el camino es distinto, excepto posiblemente por el primero y el último vértice. Un bucle es un camino de longitud 1 que comienza y termina en el mismo vértice.

