<?php

/*
  Crea una función que reciba dos array, un booleano y retorne un array.
  - Si el booleano es verdadero buscará y retornará los elementos comunes
    de los dos array.
  - Si el booleano es falso buscará y retornará los elementos no comunes
    de los dos array.
  - No se pueden utilizar operaciones del lenguaje que
    lo resuelvan directamente.
 */

 function arrayDiff($a1, $a2, $bool){
    $rec = []; 
    $ar = count($a1) > count($a2) ? $a1 : $a2;
    $ar2 = count($a1) < count($a2) ? $a1 : $a2;
    
    foreach($ar as $element){
        if($bool) {
            if(in_array($element, $ar2)) {
                $rec[] = $element;  
            }
        } else {
             if(!in_array($element, $ar2)) {
                $rec[] = $element;  
            }
        }
    }

    return print_r($rec, true);
}

$array1 = array("green", "red", "blue", "red");
$array2 = array("green", "yellow", "red");

echo arrayDiff($array1, $array2, true) . "\n";
echo arrayDiff($array1, $array2, false) . "\n";
?>
