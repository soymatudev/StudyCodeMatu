/*
  Crea una función que reciba un texto y muestre cada palabra en una línea,
  formando un marco rectangular de asteriscos.

  - ¿Qué te parece el reto? Se vería así:
    **********
    * ¿Qué   *
    * te     *
    * parece *
    * el     *
    * reto?  *
    **********
 */
 
using System;

public class MarcoPalabras
{
    public static void Main(string[] args)
    {
        string cadena = "¿Que te parece el reto?";
        setMarco(cadena.Split(" "));
    }
    
    public static void setMarco(string[] cadena) {
        string marco = ""; 
        
        int lon = longitud(cadena);
        marco = bases(marco, lon);
        marco = marco + "\n";
        
        for(int i = 0; i < cadena.Length; i++){
            cadena[i] = "* " + cadena[i];
            int canEs = (lon) - cadena[i].Length;;
            
            for(int j = 0; j < (canEs); j++) {
                cadena[i] = cadena[i] + " ";
            }
            
            cadena[i] = cadena[i]+" *";
            marco = marco + cadena[i] + "\n";
        }
        
        marco = bases(marco, lon);
        Console.WriteLine(marco);
    }
    
    public static int longitud(string[] cadena) {
        int lon = 0;
        foreach(string palabra in cadena) {
            int len = palabra.Length + 2;
            lon = len > lon ? len : lon;
        }
        return lon;
    }
    
    public static string bases(string marco,int lon) {
         for(int i = 0; i <= lon+1; i++) {
            marco = marco + "*";
        }
        return marco;
    }
}