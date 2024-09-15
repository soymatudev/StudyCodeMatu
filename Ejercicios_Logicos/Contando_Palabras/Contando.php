<?php
/*
  Crea un programa que cuente cuantas veces se repite cada palabra
  y que muestre el recuento final de todas ellas.
  - Los signos de puntuación no forman parte de la palabra.
  - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
  - No se pueden utilizar funciones propias del lenguaje que
    lo resuelvan automáticamente.
 */

 function contador($cadena) {
    $contador = [];
    $caracteres = [",", ".", ";", ":", "'", '"', "{", "}", "(", ")", "?"]; // Caracteres a eliminar o no validos
    $cadena = str_replace($caracteres, "", $cadena);
    $cadena = explode(" ", $cadena);
    
    echo print_r($cadena, true);
    
    foreach($cadena as $palabra) {
        if (isset($contador[$palabra])) {
            $contador[$palabra] += 1; 
        } else {
            $contador[$palabra] = 1; 
        }
    }
    
    echo print_r($contador, true);
}

contador("hola mundo hola hola hola, hola?");

?>