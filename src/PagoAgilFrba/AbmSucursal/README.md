# ABM Sucursal

Esta funcionalidad permite crear, modificar y eliminar una sucursal del sistema de
cobro de facturas. Las sucursales poseen usuarios cobradores, si se quiere dar de baja
una sucursal se deberá tener en cuenta que ninguno de los usuarios que la componen
podrán loguearse en el sistema.
Dar de alta una nueva sucursal implica cargar los siguientes datos:
* Nombre
* Dirección.
* Código Postal.

Todos los datos mencionados anteriormente son obligatorios. Bajo ninguna
circunstancia puede haber más de una sucursal por código postal existente.
La eliminación de una sucursal implica su baja lógica. Se debe poder volver a
habilitar una sucursal inhabilitada desde la sección de modificación y la misma debe
cumplir con las restricciones del párrafo anterior.
Para elegir una sucursal que se desea modificar o eliminar se debe presentar un
buscador con listado, que permita filtrar por cualquiera de sus campos.

## Algunas imágenes

### Menú Principal
![GitHub AbmSucursal](/images/AbmSucursal/AbmSucursal.png)

### Alta
![GitHub AltaSucursal](/images/AbmSucursal/AltaSucursal.png)

### Baja
![GitHub BajaSucursal](/images/AbmSucursal/BajaSucursal.png)

### Modificación
![GitHub ModifSucursal](/images/AbmSucursal/ModifSucursal.png)
