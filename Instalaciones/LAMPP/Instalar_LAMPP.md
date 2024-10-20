# XAMPP / LAMPP☕

### XAMPP es el entorno más popular de desarrollo con PHP

XAMPP es una distribución de Apache completamente gratuita y fácil de instalar que contiene **MariaDB, PHP y Perl**. El paquete de instalación de XAMPP ha sido diseñado para ser increíblemente fácil de instalar y usar.

# Instalación XAMPP en Sistema Windows

Descarga e instala Xampp según la versión de tu sistema operativo Windows.

- Sigue las instrucciones que te indica la propia instalación de xampp

- Sola Siguiente a todo si no quieres entrar en problemas de configuración

- [Download Xampp for Windows](https://www.apachefriends.org/es/index.html)

# Instalación LAMPP en Sistema Fedora

### 1. Actualizar el sistema

- Abre una terminal y ejecuta el siguiente comando para actualizar los repositorios y paquetes:

```bash
  sudo dnf update
```

### 2. Instalar Apache

- Instala el servidor web Apache:

```bash
  sudo dnf install httpd
```

- Inicia y habilita Apache para que arranque al iniciar el sistema:

```bash
  sudo systemctl start httpd
  sudo systemctl enable httpd
```

- Verifica el estado del servicio:

```bash
  sudo systemctl status httpd
```

- Abre un navegador y dirígete a http://localhost, deberías ver la página predeterminada de Apache.

### 3. Instalar MariaDB (MySQL)

- Fedora utiliza MariaDB en lugar de MySQL, pero es completamente compatible:

```bash
  sudo dnf install mariadb-server mariadb
```

- Inicia y habilita MariaDB:

```bash
  sudo systemctl start mariadb
  sudo systemctl enable mariadb
```

- Asegura la instalación de MariaDB ejecutando:

```bash
  sudo mysql_secure_installation
```

- Sigue las instrucciones para establecer una contraseña segura y configurar las opciones de seguridad.

### 4. Instalar PHP

- Instala PHP junto con los módulos necesarios:

```bash
  sudo dnf install php php-mysqlnd
```

- Reinicia Apache para que cargue PHP:

```bash
  sudo systemctl restart httpd
```

- Verifica la versión de PHP:

```bash
  php -v
```

### 5. Configurar Apache para Priorizar PHP (Puede que este paso no te funcione, aparecerá algo similar en la "Configuración Adicional")

- Abre el archivo de configuración de Apache:

```bash
  sudo nano /etc/httpd/conf.d/php.conf
```

- Asegúrate de que index.php esté listado antes que otros archivos:

```bash
  DirectoryIndex index.php index.html
```

### 6. Reiniciar Apache

- Reinicia el servicio Apache para que se apliquen los cambios:

```bash
  sudo systemctl restart httpd
```

### 7. Probar PHP

- Crea un archivo de prueba PHP en el directorio raíz web:

```bash
  sudo nano /var/www/html/info.php
```

- Añade el siguiente código:

```bash
  <?php
  phpinfo();
  ?>
```

- Guarda el archivo y luego abre http://localhost/info.php en tu navegador para verificar que PHP esté funcionando.

### 8. Instalar phpMyAdmin (Opcional)

- Si necesitas gestionar las bases de datos de MariaDB desde una interfaz gráfica, puedes instalar phpMyAdmin:

```bash
  sudo dnf install phpMyAdmin
```

- Una vez instalado, reinicia Apache y accede a http://localhost/phpmyadmin.

### 9. Habilitar módulos adicionales de Apache (Opcional)

- Si necesitas habilitar el módulo rewrite para el uso de URLs amigables

```bash
  sudo dnf install mod_rewrite
  sudo systemctl restart httpd
```

### 10. Seguridad y Firewall

- Permite el tráfico HTTP y HTTPS a través del firewall de Fedora:

```bash
  sudo firewall-cmd --permanent --add-service=http
  sudo firewall-cmd --permanent --add-service=https
  sudo firewall-cmd --reload
```

### 11. Eliminar archivo de prueba PHP

- Después de verificar que PHP funciona correctamente, elimina el archivo de prueba:

```bash
  sudo rm /var/www/html/info.php
```
