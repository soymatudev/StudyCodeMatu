#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char *argv[])
{
    // Valores dados de los usuarios
    float catetoA = 0.0f, catetoB = 0.0f;
    // Valores calculados
    float hipotenusa = 0.0f, area = 0.0f, perimetro = 0.0f;

    printf("Ingrese el valor del cateto A: \n");
    scanf("%f", &catetoA);
    printf("\n");

    printf("Ingrese el valor del cateto B: \n");
    scanf("%f", &catetoB);
    printf("\n");

    if (catetoA <= 0 || catetoB <= 0)
    {
        printf("Los valores de los catetos deben ser mayores a 0 \n");
    }
    else
    {
        hipotenusa = sqrtf(powf(catetoA, 2) + powf(catetoB, 2));
        perimetro = catetoA + catetoB + hipotenusa;
        area = (catetoA * catetoB) / 2;

        printf("El valor de la hipotenusa es %.2f \n ", hipotenusa);
        printf("El valor del perimtro es %.2f \n ", perimetro);
        printf("El valor del area es %.2f \n ", area);
    }
    return 0;
}