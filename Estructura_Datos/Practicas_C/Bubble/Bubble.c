#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Declaracion de variables y del arreglo
    int coleccion[] = {5, 10, 2, 12, 1};
    int aux = 0;
    int n = sizeof(coleccion) / sizeof(coleccion[0]);

    // Ordenar la coleccion
    // El primer hace que se repita el proceso el numero de veces segun el tamaño de la coleccion
    // El -1 es para que no se compare el ultimo elemento con el siguiente ya que no hay siguiente
    for (int i = 0; i < n - 1; i++)
    {
        //  El segundo for hace que se compare el elemento actual con el siguiente
        //  El -1 es para que no se compare el ultimo elemento con el siguiente ya que no hay siguiente
        //  El -i es para que no se compare con los elementos que ya estan ordenados al final de la coleccion
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (coleccion[j] > coleccion[j + 1])
            {
                aux = coleccion[j];
                coleccion[j] = coleccion[j + 1];
                coleccion[j + 1] = aux;
            }
        }
        // Imprimir la coleccion ordenada por vuelta
        printf("\nColeccion ordenada Por vuelta: ");
        printf("%d \n", i);
        for (int i = 0; i < n; i++)
        {
            printf("%d \n", coleccion[i]);
        }
    }

    // Imprimir la coleccion ordenada
    printf("\nColeccion ordenada: \n");
    for (int i = 0; i < n; i++)
    {
        printf("%d \n", coleccion[i]);
    }

    return 0;
}