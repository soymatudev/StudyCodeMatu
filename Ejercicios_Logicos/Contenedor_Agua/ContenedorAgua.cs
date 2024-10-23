/*
  Dado un array de números enteros positivos, donde cada uno
  representa unidades de bloques apilados, debemos calcular cuantas unidades
  de agua quedarán atrapadas entre ellos.
 
  - Ejemplo: Dado el array [4, 0, 3, 6, 1, 3].
 
          ⏹
          ⏹
    ⏹💧💧⏹
    ⏹💧⏹⏹💧⏹
    ⏹💧⏹⏹💧⏹
    ⏹💧⏹⏹⏹⏹
 
    Representando bloque con ⏹︎ y agua con 💧, quedarán atrapadas 7 unidades
    de agua. Suponemos que existe un suelo impermeable en la parte inferior
    que retiene el agua.
*/
 
using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numeros = { 4, 0, 3, 6, 1, 3 };
        container(numeros);
    }
    
    static void container(int[] arr) {
        int max = arr.Max();
        string[,] contenedor = new string[max,arr.Length];
        
        for(int i = arr.Length-1; i >= 0; i--) {
            for(int j = max-1; j >= 0; j--) {
                if(arr[i] > j) {
                    contenedor[i,j] = "#";
                } else {
                    contenedor[i,j] = "*";
                }
            }
        }
        
        for(int i = arr.Length-1; i >= 0; i--) {
            for(int j = 0; j < max; j++) {
                Console.Write(contenedor[j,i] + " ");
            }
            Console.WriteLine();
        }
        
    }
}






