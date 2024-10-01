
# Comando Básicos de Fedora (Red Hat) ☕

## Navegación en el sistema de archivos
| Descripción del comando | Comando |
|---|---|
| Muestra el contenido del directorio actual | ls |
| Cambia al directorio especificado | cd directorio |
| Crea un nuevo directorio | mkdir nombre_directorio |
| Elimina un directorio vacío | rmdir nombre_directorio |

## Gestión de archivos
| Descripción del comando | Comando |
|---|---|
| Copia archivos o directorios | cp origen destino |
| Mueve o renombra archivos o directorios | mv origen destino |
| Elimina archivos o directorios | rm archivo_o_directorio |

## Visualización de archivos
| Descripción del comando | Comando |
|---|---|
| Muestra el contenido de un archivo de texto | cat archivo.txt |
| Muestra el contenido de un archivo de forma paginada | less archivo.txt |

## Modicicación de archivos
| Descripción del comando | Comando |
|---|---|
| Modificar el contenido de un archivo | nano archivo.txt |

## Permisos de archivos
| Descripción del comando | Comando |
|---|---|
| Cambia los permisos de un archivo o directorio | chmod permisos archivo_o_directorio |

## Búsqueda de archivos
| Descripción del comando | Comando |
|---|---|
| Busca archivos por nombre | find directorio_a_buscar -name "nombre_archivo" |

## Gestión de paquetes
| Descripción del comando | Comando |
|---|---|
| Actualiza la lista de paquetes disponibles | dnf update |
| Instala un paquete | dnf install nombre_paquete |
| Elimina un paquete | dnf remove nombre_paquete |

## Información del sistema
| Descripción del comando | Comando |
|---|---|
| Muestra información del sistema | uname -a |

## Usuarios y grupos
| Descripción del comando | Comando |
|---|---|
| Agrega un nuevo usuario | useradd nombre_usuario |
| Elimina un usuario | userdel nombre_usuario |

## Otros comandos útiles
| Descripción del comando | Comando |
|---|---|
| Limpia la pantalla | clear |
| Reinicia el sistema | reboot |
| Apaga el sistema | shutdown -h now |

## Comandos específicos de Fedora
| Descripción del comando | Comando |
|---|---|
| Busca paquetes por palabras clave | dnf search |
| Lista los grupos de paquetes disponibles | dnf grouplist |
| Instala un grupo de paquetes | dnf groupinstall |
| Gestor de servicios y unidades del sistema | systemd |
| Configura el firewall de firewalld | firewall-cmd |
| Resuelve problemas relacionados con SELinux | setroubleshoot |
| Personaliza el entorno de escritorio GNOME (si se utiliza) | gnome-tweaks |
| Configura el entorno de escritorio KDE (si se utiliza) | kde-config |