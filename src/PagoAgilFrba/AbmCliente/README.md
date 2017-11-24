## ABM Cliente

Funcionalidad que permite crear, modificar y dar de baja un nuevo cliente al
sistema. Estos clientes son aquellos que se acercan a la ventanilla de sucursal de cobro
para efectuar el pago de uno o más servicios y del cual nuestra empresa de cobro de
servicios quiere llevar un registro para funcionalidades futuras o hacerle llegar
información pertinente.
Dar de alta un cliente implica el ingreso de los siguientes datos:
* Nombre.
* Apellido.
* DNI.
* Mail.
* Teléfono.
* Dirección calle, nro piso, depto y localidad
* Código Postal
* Fecha de Nacimiento.

Todos los datos mencionados anteriormente son modificables, en cuanto a la
obligatoriedad de los mismos, es para todos los datos. El mail es un dato único, por ende
no pueden existir 2 clientes con el mismo mail. El sistema deberá controlar esta
restricción e informar debidamente al usuario ante alguna anomalía.
La eliminación de un cliente implica la baja lógica del mismo. Un cliente
inhabilitado no podrá efectuar pago de servicios. Se debe poder volver a habilitar el
cliente deshabilitado desde la sección de modificación.
Para elegir que cliente se desea modificar o eliminar se debe presentar un
buscador con listado, que permita filtrar simultáneamente por alguno o todos los
siguientes campos:
* Nombre (texto libre)
* Apellido (texto libre)
* DNI (texto libre exacto)

## Algunas imagenes

### Menú Principal
![GitHub AbmCliente](/images/AbmCliente/AbmCliente.png)

### Alta
![GitHub AltaCliente](/images/AbmCliente/AltaCliente.png)

### Baja
![GitHub BajaCliente](/images/AbmCliente/BajaCliente.png)

### Modificación
![GitHub ModifCliente](/images/AbmCliente/ModifCliente.png)
