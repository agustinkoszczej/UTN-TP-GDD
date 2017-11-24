# **Gestión de Datos UTN FRBA - TP 2017 2C:**
# **LORDS_OF_THE_STRINGS_V2**
 
![GitHub Pago_Agil](/images/Pago_Agil.png)
 
## **Pago Ágil**
El presente TP describe la situación en donde una empresa de cobranza de impuestos de
rubros generales (Pago Ágil) se encarga de recepcionar el pago de diferentes facturas
por parte de diversas personas que se acercan una determinada sucursal para que se les
cobre las mismas.
Uno de los tipos de usuarios del sistema, en este caso el personal de ventanilla, recibe
de una persona las diversas facturas de servicios que quieran pagar, en donde dicho
empleado de ventanilla registra el pago de ellas. Luego de recibido el pago, los
administradores del sistema (el segundo tipo de usuario del sistema) se encargan de
realizar las rendiciones pertinentes a las empresas de servicios por los servicios que se
han cobrado en ventanilla por los cobradores.
Esta empresa de cobro dispone de varias sucursales a lo largo de todo el país y la idea
de este TP es reemplazar el viejo sistema de registración que existía.
Tener en cuenta que por fines académicos esto solo es una aproximación o simulación
de dicha situación.

## **Diagrama Entidad Relación (DER):**

![GitHub Pago_Agil](/images/DER_Pago_Agil.png)

## **Integrantes:**

| Legajo | Apellido | Nombre | Curso | Github |
| -------- | -------- | -------- | -------- | -------- |
| 156.102-9 | Koszczej | Agustín | K3521 | [agustinkoszczej](https://github.com/agustinkoszczej) |
| 156.101-7 | Manchione | Bruno | K3573 | [BrunoManchione](https://github.com/BrunoManchione) |

## **Componentes del Sistema:**
* [Base de Datos](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/data)
* [Aplicación Desktop](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba)
  * [ABM Cliente](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/AbmCliente)
  * [ABM Empresa](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/AbmEmpresa)
  * [ABM Factura](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/AbmFactura)
  * [ABM Rol](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/AbmRol)
  * [ABM Sucursal](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/AbmSucursal)
  * [Devolución](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/Devolucion)
  * [Listado Estadístico](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/ListadoEstadistico)
  * [Login](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/Login)
  * [Registro de Pagos](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/RegistroPago)
  * [Rendición de Facturas](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba/Rendiciones)


## **Entregas:**

* Entrega Obligatoria del DER
  * ~~Fecha: 05/10/2017~~

* Entrega del Sistemas Completo
  * ~~Fecha: 05/11/2017~~
    * ~~Fecha de primer recuperatorio: ?~~
    
    * ~~Fecha de segundo recuperatorio: 07/12/2017~~

## **Instalación:**

#### 1. Instalar el motor de base de datos Microsoft SQL Server 2012 Express

#### 2. Crear una instancia del motor de base de datos

    ● El nombre de la instancia del motor de base de datos a instalar debe llamarse “SQLSERVER2012”. 
      No utilizar el nombre “Default” para la instancia. Instalar como instancia con nombre (“Named Instance”)
    ● La autenticación debe ser por “Modo Mixto”
       
#### 3. El usuario administrador de la base de datos deberá tener la siguiente configuración:
    ● Username: “sa”
    ● Password: “gestiondedatos”
    
#### 4. Crear un nuevo “Inicio de Sesión”, desde el item “Seguridad” perteneciente al servidor de Base de Datos general. El inicio de sesión debe poseer las siguientes características:

    ● Solapa “General”:
    ● Nombre de inicio de sesión: “gd”
    ● Autenticación de SQL Server
    ● Contraseña: “gd2017”
    ● Base de Datos Predeterminada: GD2C2017.
    ● El resto de los parámetros respetar sus valores default.
    ● Solapa “Funciones del Servidor”:
    ● Seleccionar “sysadmin”
    ● Solapa “Asignación de Usuarios”:
    ● Seleccionar asignar a “GD2C2017”
    ● Para el resto de los parámetros respetar sus valores default.   
    
#### 5. Salir del “Management Studio” como usuario “sa” y volver a ingresar con el nuevo usuario “gd” creado. Es probable que informe que la contraseña ha caducado. Cambiar la contraseña ingresando exactamente la misma que antes: “gd2017”

#### 6. Correr el [EjecutarScriptTablaMaestra.bat](https://github.com/agustinkoszczej/UTN-TP-GDD/blob/master/data/EjecutarScriptTablaMaestra.bat) 

    El Script necesita aproximadamente 40 minutos para finalizar su ejecución

#### 7. Correr el [script_creacion_inicial.sql](https://github.com/agustinkoszczej/UTN-TP-GDD/blob/master/data/script_creacion_inicial.sql) en el SQL Server

     El Script necesita aproximadamente 1 minuto para finalizar su ejecución
   
#### 8. Instalar el Microsoft Visual C# 2012 Express Edition

#### 9. Importar la [Aplicación Desktop](https://github.com/agustinkoszczej/UTN-TP-GDD/tree/master/src/PagoAgilFrba) en el Visual Studio 2012 Express y ejecutarlo

## **Parámetros de Configuración**
Se encuentran en el archivo [App.config](https://github.com/agustinkoszczej/UTN-TP-GDD/blob/master/src/PagoAgilFrba/App.config) y definen las partes configurables de la aplicación.

* **server/user/password:** cadena de conexión de la aplicación. Define la ubicación de la base de datos, su usuario y su password.
* **porcentajeComision:** corresponde al porcentaje de rendición de la aplicación.
* **fecha:** la fecha actual del sistema para realizar pruebas a la aplicación.

## **Github:**
* https://github.com/agustinkoszczej/UTN-TP-GDD
