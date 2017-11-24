# ABM Rol

Funcionalidad para poder crear, modificar y eliminar el acceso de un usuario a una
opción del sistema.
Crear un rol implica cargar los siguientes datos:
* Nombre
* Listado de Funcionalidades (selección acotada)

Todos los datos mencionados anteriormente son obligatorios.
Un rol posee un conjunto de funcionalidades y las mismas no pueden estar
repetidas dentro de un rol en particular, además, una funcionalidad puede estar en más
de un rol al mismo tiempo. Debe tenerse en cuenta, que actualmente existen 2 roles.
* Administradores
* Cobradores

En la modificación de un rol solo se pueden alterar los campos: nombre y el
listado de funcionalidades. Se deben poder quitar de a una las funcionalidades como así
también agregar nuevas funcionalidades a rol que se está modificando.
La eliminación del rol implica una baja lógica del mismo, ósea, el rol debe poder
inhabilitarse. No está permitida la asignación de un rol inhabilitado a un usuario, por
ende, se debe quitar el rol inhabilitado a todos aquellos usuarios que lo posean. Un
usuario puede tener más de un rol asignado.
Se debe poder volver a habilitar un rol inhabilitado desde la sección de
modificación. Esto no implica recuperar las asignaciones que existían en un pasado.
Para elegir el rol que se desea modificar o eliminar se debe mostrar un listado con
todos los roles existentes en el sistema.

## Algunas imágenes

### Menú Principal
![GitHub AbmRol](/images/AbmRol/AbmRol.png)

### Alta
![GitHub AltaRol](/images/AbmRol/AltaRol.png)

### Baja
![GitHub BajaRol](/images/AbmRol/BajaRol.png)

### Modificación
![GitHub ModifRol](/images/AbmRol/ModifRol.png)
