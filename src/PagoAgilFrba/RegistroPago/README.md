# Registro de Pagos

Esta funcionalidad permite registrar el pago de un cliente por parte del operador de
cobro de una o más facturas que dicho cliente presente.
Para llevar a cabo esta acción el operador procederá a ingresar los datos de la/s
factura/s:
* Número de factura
* Fecha de cobro (automática del sistema)
* Empresa (selección acotada)
* Cliente (selección acotada)
* Fecha de vencimiento de la factura.
* Importe
* Sucursal

Todos los datos mencionados anteriormente son obligatorios.
Para la carga de estos datos, el cobrador hará una inspección visual del soporte
papel (factura) entregada por el cliente y cargará los datos que correspondan. Se debe
controlar que la fecha de vencimiento a ingresar sea menor o igual a la fecha del
sistema, del mismo modo no puede haber facturas con importe menor o igual a cero.
Otro punto a corroborar es que la empresa a elegir debe estar activa, no se pueden
registrar pagos a empresas que no estén activas.
El operador ingresará tantas facturas como sea las que entregue el cliente en
cuestión, luego de finalizada la carga total de facturas entregadas, se registrará el pago
por el total de las mismas. Los medios de pago pueden ser en efectivo u otros medios de
pagos que los alumnos crean convenientes, según su creatividad, debiendo ser más de
uno para dar más de una posibilidad de pago.
Del mismo modo se deberá registrar la sucursal en la cual se efectuó el pago,
dicho dato se obtendrá del usuario operador. En caso de que el operador trabaje en más
de una sucursal, se deberá tomar aquella que se seleccionó al momento del login cuando
el cobrador ingresó al sistema.

## Algunas imágenes

### Menú Principal
![GitHub RegistroPago](/images/RegistroPago/RegistroPago.png)

#### Confirmación Pago
![GitHub ConfirmarPago](/images/RegistroPago/ConfirmarPago.png)

#### Pago Correcto
![GitHub PagoCorrecto](/images/RegistroPago/PagoCorrecto.png)
