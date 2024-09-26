/*
  Crea un programa que calcule el daño de un ataque durante
  una batalla Pokémon.

  - La fórmula será la siguiente: daño = 50 * (ataque / defensa) * efectividad
  - Efectividad: x2 (súper efectivo), x1 (neutral), x0.5 (no es muy efectivo)
  - Sólo hay 4 tipos de Pokémon: Agua, Fuego, Planta y Eléctrico 
    (buscar su efectividad)
  
  - El programa recibe los siguientes parámetros:
   - Tipo del Pokémon atacante.
   - Tipo del Pokémon defensor.
   - Ataque: Entre 1 y 100.
   - Defensa: Entre 1 y 100.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class BatallaPokemon
{
    class Pokemon {
        public string[] spEfect {get; set;}
        public string[] neEfect {get; set;}
        public string[] noEfect {get; set;}
    }
    
    public static void Main(string[] args)
    {
        battle("Water", "Grass", 100, 100);
        battle("Fire", "Water", 100, 100);
        battle("Fire", "Grass", 100, 100);
    }
    
    static void battle(string ty1, string ty2, int attak, int defense) {
        (double val, string str) effect = calcEffect(ty1, ty2);
        double damage = 0; 
        damage = 50 * (attak / defense) * effect.val;
        
        Console.WriteLine("El Ataque {0}", effect.str);
        Console.WriteLine("Daño realizado: {0}", damage);
    }
    
    static (double val, string str) calcEffect(string ty1, string ty2) {
        (double val, string str) effect = (1.0, "Buen Ataque");
        var pokemons = setPokemon();
        effect = pokemons[ty1].spEfect.Contains(ty2) ? (2.0, "Es Muy Efectivo") : effect;
        effect = pokemons[ty1].noEfect.Contains(ty2) ? (0.5, "No es Muy Efectivo") : effect;
        
        return effect;
    }
    
    static Dictionary<string, Pokemon> setPokemon() {
        var pokemons = new Dictionary<string, Pokemon>(){
            {"Water", new Pokemon {spEfect= new[] {"Fire"}, neEfect= new[] {"Electric"}, noEfect= new[] {"Grass", "Water"}
            }},
            {"Fire", new Pokemon {spEfect= new[] {"Grass"}, neEfect= new[] {"Electric"}, noEfect= new[] {"Fire", "Water"}
            }},
            {"Electric", new Pokemon {spEfect= new[] {"Water"}, neEfect= new[] {"Fire"}, noEfect= new[] {"Electric", "Grass"}
            }},
            {"Grass", new Pokemon {spEfect= new[] {"Water"}, neEfect= new[] {"Electric"}, noEfect= new[] {"Fire", "Grass"}
            }}
        };
        
        return pokemons;
    }
}