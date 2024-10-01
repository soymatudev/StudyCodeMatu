## Comandos Básicos de Git y GitHub

### Inicialización y Configuración
| Descripción del comando | Comando |
|---|---|
| Inicializa un nuevo repositorio Git en el directorio actual | git init |
| Configura tu nombre y correo electrónico | git config --global user.name "Tu Nombre" <br> git config --global user.email "[dirección de correo electrónico eliminada]" |

### Seguimiento de Archivos
| Descripción del comando | Comando |
|---|---|
| Agrega todos los archivos nuevos y modificados al área de preparación | git add . |
| Agrega un archivo específico al área de preparación | git add archivo.txt |

### Creación de Instantáneas
| Descripción del comando | Comando |
|---|---|
| Crea un nuevo commit con los cambios del área de preparación | git commit -m "Mensaje de commit" |

### Ver Historial de Commits
| Descripción del comando | Comando |
|---|---|
| Muestra el historial de commits | git log |

### Gestión de Ramas
| Descripción del comando | Comando |
|---|---|
| Crea una nueva rama | git branch nueva_rama |
| Cambia a una rama existente | git checkout rama_existente |
| Crea una nueva rama y cambia a ella simultáneamente | git checkout -b nueva_rama |
| Fusiona una rama en la rama actual | git merge rama_a_fusionar |

### Interacción con Repositorios Remotos
| Descripción del comando | Comando |
|---|---|
| Agrega un repositorio remoto | git remote add origin [se quitó una URL no válida] |
| Envía los cambios locales al repositorio remoto | git push origin main |
| Descarga los cambios del repositorio remoto | git pull origin main |

### Otros Comandos Útiles
| Descripción del comando | Comando |
|---|---|
| Muestra el estado actual del repositorio | git status |
| Deshace los últimos cambios | git reset HEAD^ |
| Elimina un archivo del seguimiento de Git | git rm archivo.txt |

**Nota:**

* **`main`:** En versiones más recientes de Git, la rama principal se llama `main` en lugar de `master`.
* **`origin`:** Es el nombre comúnmente utilizado para el repositorio remoto, pero puedes usar cualquier otro nombre.
* **Reemplaza `tu_usuario` y `tu_repositorio` con tus propios valores.**

**Comandos básicos de GitHub (interfaz web):**

* **Crear un repositorio:** Crea un nuevo repositorio en tu cuenta de GitHub.
* **Fork:** Crea una copia de un repositorio existente para realizar cambios sin afectar el original.
* **Pull Request:** Envía una solicitud de fusión de tus cambios a otro repositorio.
* **Issues:** Reporta problemas o sugiere nuevas funcionalidades.

**Recursos adicionales:**

* **Documentación oficial de Git:** https://git-scm.com/doc
* **GitHub Guides:** https://docs.github.com/en

**Personalización:**

Puedes adaptar esta tabla aún más a tus necesidades, agregando secciones sobre temas específicos como:

* **Ramificación:** Creación de ramas, fusión, rebase.
* **Etiquetas:** Creación y gestión de etiquetas.
* **Submódulos:** Incorporación de otros repositorios dentro de tu proyecto.
* **GitHub Actions:** Automatización de workflows.
