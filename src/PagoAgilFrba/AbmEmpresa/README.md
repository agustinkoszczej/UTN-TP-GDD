# ABM Empresa
Esta funcionalidad permite poder crear, modificar y eliminar las empresas que
tienen convenio con nuestra entidad que registra pago de servicios
Dar de alta una nueva empresa implica cargar los siguientes datos:
* Nombre
* Cuit
* Dirección
* Rubro (selección acotada)

Todos los datos mencionados anteriormente son obligatorios.
No pueden existir en el sistema más de una empresa con el mismo cuit.
El dato rubro hace referencia al tipo de servicio que brinda la empresa a sus
respectivos clientes.
En la modificación de una empresa se pueden alterar todos sus datos.
Cuando se trate de una baja, la misma será lógica. Para una empresa inactiva sus
datos seguirán existiendo en la base de datos. Se debe poder volver a habilitar dicha
empresa inhabilitada desde la sección de modificación, si la empresa se encuentra
inactiva no se podrán registrar cobros de facturas a su nombre. Dada dicha situación, el
cliente deberá buscar otro medio de pago para sus facturas. Además tampoco está
permitido realizar rendiciones a empresas que se encuentren inactivas, se deberá
controlar al momento de cambiar el estado de una empresa si hay facturas pendientes de
rendición. Para por poner una empresa en estado inactivo debe estar todas sus facturas
cobradas de manera rendidas.
Para elegir una empresa que se desea modificar o eliminar se debe presentar un
buscador con listado, que permita filtrar simultáneamente por alguno o todos los
siguientes campos:
* Nombre
* Cuit
* Rubro (selección acotada)

## Algunas imagenes

### Menú Principal
![GitHub AbmEmpresa](/images/AbmEmpresa/AbmEmpresa.png)

### Alta
![GitHub AltaCliente](/images/AbmEmpresa/AltaEmpresa.png)

### Baja
![GitHub BajaCliente](/images/AbmEmpresa/BajaEmpresa.png)

### Modificación
![GitHub ModifCliente](/images/AbmEmpresa/ModifEmpresa.png)
