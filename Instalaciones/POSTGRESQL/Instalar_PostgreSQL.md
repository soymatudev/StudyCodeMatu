# PostgreSQL ☕

### PostgreSQL es el DBMS más popular, conocido por su robustez y extensibilidad.

PostgreSQL es un sistema de gestión de bases de datos relacional de código abierto. **PostgreSQL** admite tipos de datos avanzados, operaciones complejas y permite a los usuarios definir funciones y operadores personalizados.

# Instalación PostgreSQL en Sistema Windows

Descarga e instala PostgreSQL según la versión de tu sistema operativo Windows.

- Sigue las instrucciones que te indica la propia instalación de postgresql

- Solo da Siguiente a todo si no quieres entrar en problemas de configuración

- [Download PostgreSQL for Windows](https://www.postgresql.org/download/windows/)

# Instalación PostgreSQL en Sistema Fedora

### 1. Actualizar el sistema

- Abre una terminal y ejecuta el siguiente comando para actualizar los repositorios y paquetes:

```bash
  sudo dnf update
```

### 2. Instalar desde el RPM desde el repositorio de Postgresql

- Verifica la version de tu Sistema Fedora y cambia la versión

- Instala el RPM desde un repostorio remoto:

```bash
  sudo dnf install -y https://download.postgresql.org/pub/repos/yum/reporpms/F-39-x86_64/pgdg-fedora-repo-latest.noarch.rpm
```

### 3. Instalar el servidor de PostgreSQL

- Fedora utiliza un servicio de postgresql que lo mantiene activo y funcionando:

```bash
  sudo dnf install postgresql-server
```

### 4. Habilitar el Servicio

- Habilita el servicio dentro del sistema para su uso:

```bash
  sudo dnf install postgresql-server
```

- Iniciamos el servicio:

```bash
  sudo systemctl start postgresql
```

### 1. Si No Inicia

- Asignamos el usuario de postgres al directorio creado por el servicio en /var/lib/pgsql/data

```bash
  sudo chown -R postgres:postgres /var/lib/pgsql/data
```

- Le damos los permisos necesarios:

```bash
  sudo chmod 700 /var/lib/pgsql/data
```

- Habilitamos el servicio:

```bash
  sudo systemctl enable postgresql
```

- Cargamos con initdb para que inicie con toda la configuracion:

```bash
  sudo /usr/bin/postgresql-setup initdb
```

- Lo volvemos a iniciar:

```bash
  sudo systemctl restart postgresql
```

### 2. Para Ver Sobre los Errores

```bash
  sudo journalctl -xeu postgresql.service
```