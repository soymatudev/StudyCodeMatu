<?php

/*
  Crea un programa que comprueba si los paréntesis, llaves y corchetes
  de una expresión están equilibrados.
  - Equilibrado significa que estos delimitadores se abren y cieran
    en orden y de forma correcta.
  - Paréntesis, llaves y corchetes son igual de prioritarios.
    No hay uno más importante que otro.
  - Expresión balanceada: { [ a * ( c + d ) ] - 5 }
  - Expresión no balanceada: { a * ( c + d ) ] - 5 }
 */

function Verificador($expresion) {
    $caracteres = ["{", "}", "[", "]", "(", ")"];
    $relacion = ["{" => "}", "[" => "]", "(" => ")"];
    $guardado = [];
    
    for($i = 0; $i < strlen($expresion); $i++) {
         if (in_array($expresion[$i], $caracteres)) {
            $guardado[] = $expresion[$i];
        }
    }
    
    echo print_r($guardado) . "\n";
    
    foreach($guardado as $index => $caracter) {
        if ($index < count($guardado) / 2) {
            if ($relacion[$caracter] == $guardado[(count($guardado)-1-$index)]) {
            
            } else {
                echo "La expresion no esta equilibrada \n";
                exit;
            }
        }
    }
    
    echo "La ecuacion esta equilibrada \n";
}
Verificador("{ [ a * ( c + d ) ] - 5 }");
Verificador("{ a * ( c + d ) ] - 5 }");

?>