/*
  Calcula dónde estará un robot (sus coordenadas finales) que se
  encuentra en una cuadrícula representada por los ejes "x" e "y".

  - El robot comienza en la coordenada (0, 0).
  - Para idicarle que se mueva, le enviamos un array formado por enteros
    (positivos o negativos) que indican la secuencia de pasos a dar.
  - Por ejemplo: [10, 5, -2] indica que primero se mueve 10 pasos, se detiene,
    luego 5, se detiene, y finalmente 2.
    El resultado en este caso sería (x: -5, y: 12)
  - Si el número de pasos es negativo, se desplazaría en sentido contrario al
    que está mirando.
  - Los primeros pasos los hace en el eje "y". Interpretamos que está mirando
    hacia la parte positiva del eje "y".
  - El robot tiene un fallo en su programación: cada vez que finaliza una
    secuencia de pasos gira 90 grados en el sentido contrario a las agujas
    del reloj.
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] pasos = {10, 5, -2};
        Robot robot = new Robot();
        int[] coordenadas = robot.mover(pasos);
        Console.WriteLine("La coordenadas finales del Robot son: [{0}, {1}]", coordenadas[0], coordenadas[1]);
    }
}

public class Robot {
    private int x;
    private int y;
    private int direccion;
    private readonly string[] angulo = {"arriba", "izquierda", "abajo", "derecha"};
    
    public Robot() {
        this.x = 0;
        this.y = 0;
        this.direccion = 0;
    }
    
    private void girar() {
        this.direccion = (this.direccion + 1 > 4) ? 0 : this.direccion + 1;
    }
    
    public int[] mover(int[] pasos) {
        foreach(int paso in pasos) {
            switch(angulo[this.direccion]) {
                case "arriba":
                    this.y += paso;
                    girar();
                    break;
                case "izquierda":
                    this.x -= paso;
                    girar();
                    break;
                case "abajo":
                    this.y -= paso;
                    girar();
                    break;
                case "derecha":
                    this.x += paso;
                    girar();
                    break;
            }
        }
        
        int[] coordenadas = {this.x, this.y};
        return coordenadas;
    }
}


















