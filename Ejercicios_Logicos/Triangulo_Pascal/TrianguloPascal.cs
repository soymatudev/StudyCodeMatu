/*
  Crea una función que sea capaz de dibujar el "Triángulo de Pascal"
  indicándole únicamente el tamaño del lado.
 
  - Aquí puedes ver rápidamente cómo se calcula el triángulo:
    https://commons.wikimedia.org/wiki/File:PascalTriangleAnimated2.gif
*/
using System;

public class TrianguloPascal
{
    public static void Main(string[] args)
    {
        pas(5);
    }
    
    static void pas(int lon) {
       int[,] a = new int[5, 5];
       
        for(int i = 0; i < lon; i++) {
            a[i,0] = 1;
            for(int j = 1; j < i; j++) {
                a[i,j] = a[i-1,j-1] + a[i-1,j];
            } 
            a[i,i] = 1;
        }
    
        for(int i = 0; i < lon; i++) {
            Console.Write(new string(' ', lon - i));
            for(int j = 0; j <= i; j++) {
               Console.Write(a[i,j] + " ");
            } 
            Console.WriteLine("");
        }
    }
}