# Login y Seguridad

Al ejecutar la aplicación el usuario no podrá acceder a ninguna funcionalidad del
sistema hasta completar el proceso de Login.
El proceso de Login pedirá al usuario su Username y su Password. Si Login es
correcto, el usuario podrá acceder al sistema, _EN CASO DE QUE EL USUARIO
TENGA ASIGNADO MAS DE UN ROL, SE DEBERÁ SELECCIONAR CON CUAL
DE ELLOS SE QUIERE LOGUEAR_.
Al acceder al sistema, la aplicación solo deberá generar y mostrar las entradas de
menú disponibles para este usuario, según el rol seleccionado. El usuario no debe poder
ver las funcionalidades a las que no posee acceso.
Si el Login es incorrecto el usuario no podrá acceder al sistema, para lo cual se
debe volver a mostrar nuevamente el Login para que intente otra vez. El sistema debe
llevar un registro de cantidad intentos fallidos de login. Luego de 3 intentos fallidos, en
cualquier momento, el usuario debe ser inhabilitado. Al realizar un Login satisfactorio,
el sistema deberá limpiar la cantidad de intentos fallidos.
El Login se considera una funcionalidad de características especiales. No se
considera una funcionalidad que puede ser asignada a un rol. Todos los usuarios tienen
la capacidad de utilizar el Login.

# Registro de Usuario

Para reducir el tiempo de confección del TP y así beneficiar al alumno se
determinó que no será necesario que se codifique un ABM que gestione los usuarios,
pero deben tener en cuenta que su estructura en la base de datos debe existir, la no
codificación de algún punto descripto en el presente TP no exonera la realización de
sus respectivas tablas en la base de datos.
Deberán tener en cuenta que al momento de realizar la entrega de dicho TP, deben
entregar un usuario con perfil Administrador, username ___admin___ y la password a asignar
será ___w23e___ Para el usuario cobradores, tanto aquellos que sean migrados (si existiese),
los alumnos determinarán cuáles serán los username y password, los cuales deberán ser
especificados en archivo de estrategia pedido para la entrega. Deben tener en cuenta que
los cobradores pertenecen a una sucursal en particular.
No cumplir con este último requerimiento será motivo suficiente de no corrección
del TP, pasando a re-entrega directamente, de la misma manera, que no sea necesario
codificar un ABM completo de esta funcionalidad no implica no modelar una entidad de
usuario.
Otros lineamientos a tener en cuenta son que el username debe ser único en un
todo el sistema, el password deberá almacenarse encriptado de forma irreversible bajo el
algoritmo de encriptación SHA256 (se deberá utilizar este algoritmo de encriptación de
manera exclusiva, usar otro será motivo de re-entrega). Téngase en cuenta con que
herramienta se generara la encriptación porque puede que la base de datos no tenga
dicha solución.
Por cuestiones de practicidad a la hora de probar el TP, se recomienda que el
username y el password sean iguales, a excepción del admin.

## Usuarios
| Usuario | Contraseña | Roles | Sucursales |
| -------- | -------- | -------- | -------- | 
| admin | w23e | Administrador | Cualquiera que se ingrese (trigger), excepto deshabilitadas |
| cobrador | 12345 | Cobrador | Sucursal N°2000 |
| admin_y_cobrador | 12345 | Administrador y Cobrador | Sucursal N°2000 |

## Algunas imágenes

### Login
![GitHub Login](/images/Login/Login.png)

### Selección de Rol
![GitHub SeleccionRol](/images/Login/SeleccionRol.png)

### Selección de Sucursal
![GitHub SeleccionSucursal](/images/Login/SeleccionSucursal.png)

### Menú Principal
![GitHub MenuPrincipal](/images/Login/MenuPrincipal.png)
