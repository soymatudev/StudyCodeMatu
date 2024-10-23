#include <stdio.h>
#include <stdlib.h>

int main(){
    // Declaracion de variables
    int a, b, c;
    // Pedir el primer numero al usuario
    printf("Introduce el primer numero: ");
    // Guardar los numeros en las variables a
    scanf("%d", &a);
    // Pedir el segundo numero al usuario
    printf("Introduce el segundo numero: ");
    // Guardar los numeros en la variable b
    scanf("%d", &b);
    // Sumar los numeros
    c = a + b;
    // Imprimir el resultado
    printf("La suma de %d + %d es: %d\n", a, b, c);
    // El return 0 indica que el programa termino correctamente
    return 0;
}