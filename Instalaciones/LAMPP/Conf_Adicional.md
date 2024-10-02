# Configuración Adicional para LAMPP en Sistema Fedora

### 1. Instalar el módulo de PHP para Apache

Debes asegurarte de que el módulo de PHP esté instalado para que Apache pueda procesar archivos PHP. En Fedora, este módulo puede no estar instalado automáticamente cuando instalas Apache y PHP por separado.

- Ejecuta este comando para instalar el módulo PHP para Apache:

```bash
  sudo dnf install php php-common php-cli php-fpm mod_php
```

### 2. Reiniciar Apache

- Una vez que hayas instalado el módulo PHP, reinicia el servidor Apache para que los cambios surtan efecto:

```bash
  sudo systemctl restart httpd
```

### 3. Verificar el archivo de configuración de Apache

- Asegúrate de que Apache esté configurado para manejar archivos PHP. Para ello, abre el archivo de configuración principal de Apache:

```bash
  sudo nano /etc/httpd/conf/httpd.conf
```

- Busca la siguiente línea y asegúrate de que esté presente (y no comentada), Si no la encuentras, agrégala justo debajo de las otras líneas AddType.

```bash
  AddType application/x-httpd-php .php
```

### 4. Comprobar si PHP está correctamente configurado

Es posible que la instalación de PHP esté bien, pero no configurada para interactuar con Apache. Si has instalado PHP-FPM (FastCGI Process Manager) para manejar PHP, necesitas asegurarte de que esté corriendo:

- Verifica que PHP-FPM esté instalado:

```bash
  sudo dnf install php-fpm
```

- Inicia y habilita PHP-FPM:

```bash
  sudo systemctl start php-fpm
  sudo systemctl enable php-fpm
```

- Asegúrate de que Apache esté configurado para trabajar con PHP-FPM. Para esto, necesitas editar el archivo de configuración de Apache(httpd.conf) y añadir la siguiente línea, si no está presente:
- La parte de **"\.php$"** le indica que solo los .php lo maneje con php-fpm.

```bash
  <FilesMatch "\.php$">
        SetHandler "proxy:unix:/run/php-fpm/www.sock|fcgi://localhost/"
  </FilesMatch>
```

---

# Notas 📋

- Esta configuración prioriza el procesamiento de archivos .php..

```bash
  <IfModule dir_module>
    DirectoryIndex index.php index.html
  </IfModule>
```

- Si lo anterior te da problemas para el manejo de archivos .html lo puedes dejar de la siguiente manera, esto de debera seguir permitiendo manejar archivos .php y .html.

```bash
  <IfModule dir_module>
    DirectoryIndex index.html
  </IfModule>
```
