/*
  Crea dos funciones, una que calcule el máximo común divisor (MCD) y otra
  que calcule el mínimo común múltiplo (mcm) de dos números enteros.

  - No se pueden utilizar operaciones del lenguaje que lo resuelvan directamente.
*/

using System;

public class MaxMin
{
    public static void Main(string[] args)
    {
        int mcd = MCD(4, 6);
        MCM(4, 6, mcd);
        
        mcd = MCD(24, 36);
        MCM(24, 36, mcd);
        
        mcd = MCD(12, 18);
        MCM(12, 18, mcd);
    }
    
    public static void MCM(int num1, int num2, int mcd) {
        int mcm = 0;
        Console.Write("El mcm para {0} y {1} es: ", num1, num2);
        mcm = (num1/mcd) * (num2/mcd) * mcd; 
        Console.WriteLine(mcm);
    }
    
    public static int MCD(int num1, int num2) {
        int res = 0, divisor = num2;
        int mcd = 0; 
        Console.Write("El MCD para {0} y {1} es: ", num1, num2);
        
        do {
            res = num1 % divisor;
            num1 = divisor;
            divisor = res;
            mcd = res > 0 ? res : mcd;
        } while(res > 0);
        
        Console.WriteLine(mcd);
        return mcd;
    }
}