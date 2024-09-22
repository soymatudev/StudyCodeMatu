<?php

/*
  Crea una función que calcule y retorne cuántos días hay entre dos cadenas
  de texto que representen fechas.
  - Una cadena de texto que representa una fecha tiene el formato "dd/MM/yyyy".
  - La función recibirá dos String y retornará un Int.
  - La diferencia en días será absoluta (no importa el orden de las fechas).
  - Si una de las dos cadenas de texto no representa una fecha correcta se
    lanzará una excepción.
 */
 
function count_days($f_ini, $f_fin) {
    try {
        // Formateamos las cadenas a fechas
        $f_ini = DateTime::createFromFormat("d/m/Y", $f_ini);
        $f_fin = DateTime::createFromFormat("d/m/Y", $f_fin);
        $dias = 0;
        
        // Verifica que el formateo fuera el correcto
        if(!$f_ini || !$f_fin){
            throw new Exception("Formato de Fecha Incorrecto");
        }
        
        // Convierte las fehcas a tiempo(segundos) para los calculos
        $dias = strtotime($f_ini->format("Y/m/d")) - strtotime($f_fin->format("Y/m/d"));
        $dias = ($dias/86400); // 86400 los segundos por dia
         
        // Lo hace absoluto
        return $dias < 0 ? $dias * -1 : $dias;
    } catch(Exception $e) {
        // Exception para el formato de las fechas 
        echo "Error: ", $e->getMessage(), "\n";
    }
}

echo count_days("19/09/2024", "1/09/2024") , "\n";
echo count_days("1909/2024", "1/09/2024"), "\n";
?>