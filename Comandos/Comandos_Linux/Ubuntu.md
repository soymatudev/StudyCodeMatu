# Comandos básicos de Ubuntu

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

| Descripción del comando                        | Comando                            |
| ---------------------------------------------- | ---------------------------------- |
| Cambia los permisos de un archivo o directorio | chmod permisos archivo_o_directory |

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

**Comandos específicos de Ubuntu (o comunes en distribuciones basadas en Ubuntu):**

- **Gestión de software:**
  - **`sudo apt-cache search`:** Busca paquetes por palabras clave.
  - **`sudo update-alternatives --config`:** Administra alternativas para comandos como `editor` o `pdfviewer`.
- **Herramientas de sistema:**
  - **`software-properties-common`:** Administra repositorios de software.
  - **`gnome-tweaks`:** Personaliza el entorno de escritorio GNOME.
- **Entorno de escritorio:**
  - Comandos específicos para tu entorno de escritorio (por ejemplo, `gsettings` para GNOME).

**Nota:**

- **sudo:** Al igual que en Debian, `sudo` se utiliza para ejecutar comandos con privilegios de administrador.
- **Repositorios:** Ubuntu a menudo incluye repositorios adicionales (como el universo, multiverse) que pueden contener software no libre o menos probado.
- **Entornos de escritorio:** La configuración de algunos comandos puede variar ligeramente dependiendo del entorno de escritorio que estés utilizando (GNOME, KDE, etc.).

**Personalización:**

Puedes adaptar esta tabla aún más a tus necesidades, agregando secciones sobre temas específicos como:

- **Configuración de redes:** `ifconfig`, `netstat`, `route`
- **Edición de texto:** `nano`, `vim`
- **Administración de procesos:** `ps`, `top`, `kill`
