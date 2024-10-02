# Comandos básicos de Debian ☕

## Navegación en el sistema de archivos

| Descripción del comando                    | Comando                 |
| ------------------------------------------ | ----------------------- |
| Muestra el contenido del directorio actual | ls                      |
| Cambia al directorio especificado          | cd directorio           |
| Crea un nuevo directorio                   | mkdir nombre_directorio |
| Elimina un directorio vacío                | rmdir nombre_directorio |

## Gestión de archivos

| Descripción del comando                 | Comando                 |
| --------------------------------------- | ----------------------- |
| Copia archivos o directorios            | cp origen destino       |
| Mueve o renombra archivos o directorios | mv origen destino       |
| Elimina archivos o directorios          | rm archivo_o_directorio |

## Visualización de archivos

| Descripción del comando                              | Comando          |
| ---------------------------------------------------- | ---------------- |
| Muestra el contenido de un archivo de texto          | cat archivo.txt  |
| Muestra el contenido de un archivo de forma paginada | less archivo.txt |

## Permisos de archivos

| Descripción del comando                        | Comando                             |
| ---------------------------------------------- | ----------------------------------- |
| Cambia los permisos de un archivo o directorio | chmod permisos archivo_o_directorio |

## Búsqueda de archivos

| Descripción del comando   | Comando                                         |
| ------------------------- | ----------------------------------------------- |
| Busca archivos por nombre | find directorio_a_buscar -name "nombre_archivo" |

## Gestión de paquetes

| Descripción del comando                    | Comando                         |
| ------------------------------------------ | ------------------------------- |
| Actualiza la lista de paquetes disponibles | sudo apt update                 |
| Instala un paquete                         | sudo apt install nombre_paquete |
| Elimina un paquete                         | sudo apt remove nombre_paquete  |

## Información del sistema

| Descripción del comando         | Comando  |
| ------------------------------- | -------- |
| Muestra información del sistema | uname -a |

## Usuarios y grupos

| Descripción del comando | Comando                     |
| ----------------------- | --------------------------- |
| Agrega un nuevo usuario | sudo adduser nombre_usuario |
| Elimina un usuario      | sudo deluser nombre_usuario |

## Otros comandos útiles

| Descripción del comando | Comando         |
| ----------------------- | --------------- |
| Limpia la pantalla      | clear           |
| Reinicia el sistema     | reboot          |
| Apaga el sistema        | shutdown -h now |
