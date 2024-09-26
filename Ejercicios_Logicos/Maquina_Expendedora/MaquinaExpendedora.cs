/*
  Simula el funcionamiento de una máquina expendedora creando una operación
  que reciba dinero (array de monedas) y un número que indique la selección
  del producto.

  - El programa retornará el nombre del producto y un array con el dinero
    de vuelta (con el menor número de monedas).
  - Si el dinero es insuficiente o el número de producto no existe,
    deberá indicarse con un mensaje y retornar todas las monedas.
  - Si no hay dinero de vuelta, el array se retornará vacío.
  - Para que resulte más simple, trabajaremos en céntimos con monedas
    de 5, 10, 50, 100 y 200.
  - Debemos controlar que las monedas enviadas estén dentro de las soportadas.
 */

using System;
using System.Collections.Generic;
using System.Linq;

public class MaquinaExpendedora
{
    class Articulos {
        public string? name {get; set;}
        public int cost {get; set;}
    }
    
    public static void Main(string[] args)
    {
        //Las monedas que puede tener (Una de Cada) {200, 100, 50, 10, 5};
        int[] dinero = {200, 100, 10};
        artics("201", dinero);
    }
    
    static void artics(string code, int[] dinero) {
        var artics = new Dictionary<string, Articulos>(){
            {"201", new Articulos {name="Agua", cost=50}},
            {"202", new Articulos {name="Soda", cost=10}},
        };
        
        string nameArtic = artics[code].name;
        
        if(nameArtic != "") {
            int costP = artics[code].cost;
            bool result = comprobarDinero(dinero, costP);
            
            if(result) {
                Console.WriteLine($"Compraste un(a) {artics[code].name} por {artics[code].cost}");
                
                int[] arrayCambio = cambio(dinero, costP);
                Console.WriteLine("Tu cambio es: ");
                foreach(int moneda in arrayCambio) {
                    Console.Write(moneda + ", ");
                }
            }
            
        } else {
            Console.WriteLine("El producto no existe");
        }
    }
    
    static int[] cambio(int[] dinero, int costP) {
        int[] monedasAc = {200, 100, 50, 10, 5};
        int[] arrayCambio = new int[5];
        int sumaDinero = 0; int i = 0;
        
        Array.ForEach(dinero, moneda => sumaDinero += moneda);
        int cambioTotal = sumaDinero - costP;
        
        foreach(int moneda in monedasAc) {
             if(moneda <= cambioTotal) {
                cambioTotal -= moneda;
                arrayCambio[i] = moneda;
                i++;
            }
        }
        
        return arrayCambio;
    }
    
    static bool comprobarDinero(int[] dinero, int costP) {
        int[] monedasAc = {5, 10, 50, 100, 200};
        int sumaDinero = 0; bool valido = true;
        
        Array.ForEach(dinero, 
            moneda => {
               bool rec = monedasAc.Contains(moneda);
               if(!rec) {
                    Console.WriteLine("Moneda Invalida: {0}", moneda);
                    valido = false;
               }
            }
        );
        
        if (valido) {
            Array.ForEach(dinero,  moneda => sumaDinero += moneda);
            
            if(sumaDinero < costP) {
                Console.WriteLine("Dinero insuficiente");
                valido = false;
            } else if (sumaDinero >= costP) {
                valido = true;
            }
        }
        
        return valido;
    }
}