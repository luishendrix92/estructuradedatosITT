Dados dos algoritmos distintos que solucionan un mismo problema, sus propiedades son probablemente distintas:
- Tardan tiempos distintos en solucionar el problema (eficiencia temporal)
- Usan distintos tipos de memoria (eficiencia espacial)

## ¿Cuál de ambos es mejor?
Lógicamente, el que menos tiempo emplee y menos espacio de almacenamiento necesite.
Habitualmente, nuestro objetivo principal será mejorar la eficiencia temporal.

### ¿Cómo analizar el tiempo de ejecución?
Considera el rendimiento:
- Velocidad y tamaño de entrada.
### ¿Cómo valorar la eficiencia de un algoritmo?
- Empíricamente
- Analíticamente

## Determinación Empírica
Consiste en ejecutar el algoritmo en una máquina real para instancias de diferente tamaño del problema considerado y obtener los resultados de tiempos consumidos y espacios.

## Inconvenientes
- Requiere una adecuada selección de los datos de entrada, lo cual no es siempre fácil de realizar.
- Está excesivamente ligado al compilador y a la máquina donde se realice la ejecución, por lo que en algunos casos las medidas no son extrapolables.
- Puede depender de la pericia del programador.
- Requiere múltiples ejecuciones de un mismo algoritmo, y por tanto, mucho tiempo.

## Determinación Teórica
Consiste en determinar matemáticamente la cantidad de recursos (espacio, tiempo) que consume un algoritmo en función del tamaño de las instancias de problemas que resuelve.
Por tamaño se puede entender varias cosas: número de ítems de entrada, valor(es) de los ítems, espacio de almacenamiento, etc.
La eficiencia se convierte en una función de "t" que permite calcular el espacio/tiempo requerido por el algoritmo para problemas de tamaño de entrada N.

## Determinación teórica de la eficiencia de un algoritmo
Una opción es analizar sobre el pseudocódigo o el código de tiempos abstractos de ejecución (TAE).
Para analizar el TAE hay que fijar una unidad de medida, que será las "sentencias básicas" esto independiza el análisis de la máquina.
El TAE se medirá como el número de veces que se ejecutan las sentencias básicas.
Es decir: dado un algoritmo A y una entrada I = (I1, I2, ..., IN).
TAE(I) = número de veces que se ejecutan las sentencias básicas del algoritmo "A" sobre la entrada "I".

## Tipos de Análisis
- **Peor de los casos (el peor tiempo)**: Es el tiempo máximo sobre las entradas.
- **Mejor de los casos (límite inferior en el tiempo)**: Es el menor tiempo de todas las posibles entradas.
- **Caso promedio**: Es el tiempo medio esperado sobre todas las posibles entradas de tamaño "n". Se considera una distribución de probabilidad sobre las entradas.
- **Análisis probabilístico**: Es el tiempo de ejecución esperado para una entrada aleatoria. Se expresa en el tiempo de ejecución y la probabilidad de obtenerlo.
- **Análisis amortizado**: El tiempo que se obtiene para un conjunto de ejecuciones, dividido por el número de ejecuciones.
