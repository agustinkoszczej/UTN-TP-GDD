## Rendición de Facturas

Funcionalidad que permite a los administradores de nuestra entidad de cobro
realizar la rendición de las facturas cobradas a los clientes que se acercan a nuestras
sucursales. Dichas rendiciones se realizan una vez al mes y por única vez dentro de
dicho mes para una empresa en cuestión. Las fechas de rendiciones son pactadas con
cada empresa en forma en individual, ende, no se rinde el mismo día para todas las
empresas asociadas a nuestra forma de cobro.
Estas rendiciones conforman el total cobrado para una empresa de servicios X. No
está permitido rendir 2 veces una misma factura. Dichas rendiciones incluyen a todas las
facturas del mes en cuestión.
Nuestra empresa cobra un pequeño porcentaje (ganancia por el cobro) el cual es
descontado del total rendido. Dicho importe cobrado a la empresa de servicios debe
quedar registrado el momento de la rendición como así también todas aquellas facturas
que forman parte de la rendición, se debe seguir un patrón maestro detalle para su
modelado.
Para hacer frente a esta funcionalidad es necesario que se registre los siguientes
campos:
* Fecha de rendicion.
* Cantidad de facturas rendidas
* Conjunto de facturas rendidas
* Importe – comisión por el cobro de facturas.
* Empresa
* Porcentaje de comisión (que puede variar en el tiempo, por lo cual no
puede ser fijo)
* Importe total de la rendición.

Todos los datos mencionados anteriormente son obligatorios.

## Algunas imágenes

### Menú Principal
![GitHub Rendiciones](/images/Rendiciones/Rendiciones.png)

### Rendir Todo
![GitHub RendirTodo](/images/Rendiciones/RendirTodo.png)

### Rendición Incorrecta (al rendir dos veces para una Empresa en un mismo mes)
![GitHub RendicionIncorrecta](/images/Rendiciones/RendicionIncorrecta.png)
