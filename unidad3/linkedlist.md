## LINKED LIST ESTRUCTURA

    {dato: 4, sig: -}-> {dato: 6, sig: -}-> {dato: 8, sig: -}-> null
        Primero             Segundo               Último

Donde {dato: int, sig: Nodo} es un objeto de clase Nodo.
El estado de la clase Lista (anidada o enlazada) se representa así:

|        Primero       |
|----------------------|
| {dato: 4, sig: Nodo} |

- Si la variable "Primero" es **null**, quiere decir que la lista está vacía.

- Si la propiedad "sig" del Nodo "Primero" es **null**, sólo hay un elemento
en la lista anidada, porque ==no hay dato siguiente==, sólo el actual.

### Insertar

Debe ser ordenado el dato dentro de la estructura, por tanto se recorre
linealmente hasta encontrar un dato que sea **mayor que él**.

Lista.Insertar(8) // Donde 8 es int

    # Procedimiento: Insertar
    # @param: dato (type int)
    # # # # # # # # # # # # #
    CREAR_REFERENCIA: Primero -> Actual (type Nodo)
    MIENTRAS [Actual NO SEA null]:
      SI [Actual.dato >= dato] ENTONCES: