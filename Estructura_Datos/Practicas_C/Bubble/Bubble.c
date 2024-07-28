#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Declaracion de variables y del arreglo
    int coleccion[] = {5, 10, 2, 12, 1};
    int aux = 0;

    // Ordenar la coleccion
    /* El primer hace que se repita el proceso el numero de veces
    segun el tamaño de la coleccion */
    for (int i = 0; i < 5; i++)
    {
        /* El segundo for hace que se compare el elemento actual con el siguiente*/
        for (int j = 0; j < 5; j++)
        {
            if (coleccion[j] > coleccion[j + 1])
            {
                aux = coleccion[j];
                coleccion[j] = coleccion[j + 1];
                coleccion[j + 1] = aux;
            }
        }
    }

    // Imprimir la coleccion ordenada
    printf("\nColeccion ordenada: \n");
    for (int i = 0; i < 6; i++)
    {
        printf("%d \n", coleccion[i]);
    }

    return 0;
}