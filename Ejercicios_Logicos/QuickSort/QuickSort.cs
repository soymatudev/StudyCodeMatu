/*
  Implementa uno de los algoritmos de ordenación más famosos:
  el "Quick Sort", creado por C.A.R. Hoare.
  - Entender el funcionamiento de los algoritmos más utilizados de la historia
    Nos ayuda a mejorar nuestro conocimiento sobre ingeniería de software.
    Dedícale tiempo a entenderlo, no únicamente a copiar su implementación.
  - Esta es una nueva serie de retos llamada "TOP ALGORITMOS",
    donde trabajaremos y entenderemos los más famosos de la historia.
*/
 
using System;

public class QuickSort
{
    public static void Main(string[] args)
    {
        int[] arr = {10, 80, 30, 90, 80, 40};
        int n = arr.Length;   
        
        quickSort(arr, 0, n-1);
        foreach(int a in arr) {
            Console.WriteLine(a);
        }
    }
    
    static int partition(int[] arr, int min, int max) {
        int pivot = arr[max];
        int i = min - 1;
        
        for(int j = min; j < max; j++) {
            if(arr[j] < pivot) {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        
        i++;
        int temp1 = arr[i];
        arr[i] = pivot;
        arr[max] = temp1;
        
        return i;
    }
    
    static void quickSort(int[] arr, int min, int max) {
        if(min < max) {
            int i = partition(arr, min, max);
            quickSort(arr, min, i - 1);
            quickSort(arr, i + 1, max);
        }
    }
    
}