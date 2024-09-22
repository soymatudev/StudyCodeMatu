<?php
/*
  - Escribe una función que reciba un texto y retorne verdadero o falso (Boolean) según sean o no palíndromos.
  - Un Palíndromo es una palabra o expresión que es igual si se lee de izquierda a derecha que de derecha a izquierda.
  - NO se tienen en cuenta los espacios, signos de puntuación y tildes.
  Ejemplo: Ana lleva al oso la avellana.
 */
 
 function palindromo($str) {
    $str = strtolower(eliminar_acentos_puntua($str));
    $len = strlen($str); 
    $count = 0;
    
    for($i = 0; $i < $len; $i++){
        if($str[$i] == $str[($len-1) - $i]) {
            $count++;
        }
    }
    
    return $count == ($len) ? "Verdadero" : "Falso";
 }
 
 function eliminar_acentos_puntua($cadena){
		
		//Reemplazamos la A y a
		$cadena = str_replace(
		['Á', 'À', 'Â', 'Ä', 'á', 'à', 'ä', 'â', 'ª'],
		['A', 'A', 'A', 'A', 'a', 'a', 'a', 'a', 'a'],
		$cadena
		);

		//Reemplazamos la E y e
		$cadena = str_replace(
		['É', 'È', 'Ê', 'Ë', 'é', 'è', 'ë', 'ê'],
		['E', 'E', 'E', 'E', 'e', 'e', 'e', 'e'],
		$cadena );

		//Reemplazamos la I y i
		$cadena = str_replace(
		['Í', 'Ì', 'Ï', 'Î', 'í', 'ì', 'ï', 'î'],
		['I', 'I', 'I', 'I', 'i', 'i', 'i', 'i'],
		$cadena );

		//Reemplazamos la O y o
		$cadena = str_replace(
		['Ó', 'Ò', 'Ö', 'Ô', 'ó', 'ò', 'ö', 'ô'],
		['O', 'O', 'O', 'O', 'o', 'o', 'o', 'o'],
		$cadena );

		//Reemplazamos la U y u
		$cadena = str_replace(
		['Ú', 'Ù', 'Û', 'Ü', 'ú', 'ù', 'ü', 'û'],
		['U', 'U', 'U', 'U', 'u', 'u', 'u', 'u'],
		$cadena );

		//Reemplazamos la N, n, C y c
		$cadena = str_replace(
		['Ñ', 'ñ', 'Ç', 'ç'],
		['N', 'n', 'C', 'c'],
		$cadena
		);
		
		$cadena = str_replace(
		    [",", ".", ";", ":", "'", '"', "{", "}", "(", ")", "?", " "],
	    "",
	    $cadena);
		
		return $cadena;
	}

echo palindromo("anilina") . "\n";
echo palindromo("Ana lleva al oso la avellana.") . "\n";
echo palindromo("Claramente esto no es un palindromo??[q]csa") . "\n";

?>