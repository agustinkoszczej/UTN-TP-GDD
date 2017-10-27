USE [GD2C2017]
GO
/*IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'LORDS_OF_THE_STRINGS_V2')
    DROP SCHEMA LORDS_OF_THE_STRINGS_V2
GO*/
--CREATE SCHEMA [LORDS_OF_THE_STRINGS_V2] AUTHORIZATION [gd]
GO

-------------------------------------------------------------------------------------------------
-----------------------------------CREACIÓN DE TABLES--------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Rol_Usuario', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Rol_Usuario];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Funcionalidad_Rol];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Rol', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Rol];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Funcionalidad', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Funcionalidad];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Rubro_Empresa', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Rubro_Empresa];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Rubro', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Rubro];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Usuario_Sucursal', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Usuario_Sucursal];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Pago', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Pago];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Forma_Pago', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Forma_Pago];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Sucursal', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Sucursal];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Devolucion', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Devolucion];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Item_Factura', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Item_Factura];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Factura', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Factura];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Rendicion', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Rendicion];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Empresa', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Empresa];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Cliente', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Cliente];
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].Usuario', 'U') IS NOT NULL DROP TABLE [LORDS_OF_THE_STRINGS_V2].[Usuario];

-------------------------------------------------------------------------------------------------
-- TABLE ROL
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Rol](
	[Rol_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Rol_nombre] [nvarchar](50) NOT NULL UNIQUE,
	[Rol_habilitado] [bit] NOT NULL DEFAULT 1)
GO

-------------------------------------------------------------------------------------------------
-- TABLE FUNCIONALIDAD
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Funcionalidad](
	[Func_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Func_nombre] [nvarchar](50) NOT NULL UNIQUE)
GO

-------------------------------------------------------------------------------------------------
-- TABLE FUNCIONALIDAD_ROL
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Funcionalidad_Rol](
	[FuncRol_rol] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Rol(Rol_codigo),
	[FuncRol_func] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Funcionalidad(Func_codigo),
	PRIMARY KEY (FuncRol_rol, FuncRol_func ))
GO

-------------------------------------------------------------------------------------------------
-- TABLE USUARIO
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Usuario](
	[Usuario_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Usuario_username] [nvarchar](50) UNIQUE NOT NULL,
	[Usuario_password] [nvarchar](255) NOT NULL,
	[Usuario_cant_intentos] [numeric](18, 0) NOT NULL DEFAULT 0)
GO

-------------------------------------------------------------------------------------------------
-- TABLE ROL_USUARIO
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Rol_Usuario](
	[RolUsua_usuario] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Usuario(Usuario_codigo),
	[RolUsua_rol] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Rol(Rol_codigo),
	PRIMARY KEY (RolUsua_usuario, RolUsua_rol))
GO

-------------------------------------------------------------------------------------------------
-- TABLE CLIENTE
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Cliente](
	[Cliente_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Cliente_dni] [numeric](18, 0) UNIQUE NOT NULL,
	[Cliente_nombre] [nvarchar](255) NOT NULL,
	[Cliente_apellido] [nvarchar](255) NOT NULL,
	[Cliente_fecha_nac] [datetime] NOT NULL,
	[Cliente_mail] [nvarchar](255) NULL UNIQUE,
	[Cliente_direccion] [nvarchar](255) NOT NULL,
	[Cliente_codigo_postal] [nvarchar](255) NOT NULL,
	[Cliente_telefono] [nvarchar](50) NULL,
	[Cliente_habilitado] [bit] NOT NULL DEFAULT 1)
GO

-------------------------------------------------------------------------------------------------
-- TABLE RUBRO
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Rubro](
	[Rubro_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Rubro_descripcion] [nvarchar](50) NOT NULL UNIQUE)
GO

-------------------------------------------------------------------------------------------------
-- TABLE EMPRESA
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Empresa](
	[Empresa_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Empresa_cuit] [nvarchar](50) NOT NULL,
	[Empresa_nombre] [nvarchar](255) NOT NULL,
	[Empresa_direccion] [nvarchar](255) NOT NULL,
	[Empresa_habilitada] [bit] NOT NULL DEFAULT 1)
GO

-------------------------------------------------------------------------------------------------
-- TABLE RUBRO_EMPRESA
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Rubro_Empresa](
	[RubroEmpr_empresa] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Empresa(Empresa_codigo),
	[RubroEmpr_rubro] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Rubro(Rubro_codigo),
	PRIMARY KEY (RubroEmpr_empresa, RubroEmpr_rubro))
GO

-------------------------------------------------------------------------------------------------
-- TABLE SUCURSAL
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Sucursal](
	[Sucursal_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Sucursal_nombre] [nvarchar](50) NOT NULL,
	[Sucursal_direccion] [nvarchar](255) NOT NULL,
	[Sucursal_codigo_postal] [nvarchar](255) NOT NULL UNIQUE,
	[Sucursal_habilitada] [bit] NOT NULL DEFAULT 1)
GO

-------------------------------------------------------------------------------------------------
-- TABLE USUARIO_SUCURSAL
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Usuario_Sucursal](
	[UsuarioSucur_usuario] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Usuario(Usuario_codigo),
	[UsuarioSucur_sucursal] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Sucursal(Sucursal_codigo),
	PRIMARY KEY (UsuarioSucur_usuario, UsuarioSucur_sucursal))
GO

-------------------------------------------------------------------------------------------------
-- TABLE RENDICION
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Rendicion](
	[Rendicion_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Rendicion_fecha] [datetime] NOT NULL,
	[Rendicion_importe] [numeric](18, 2) NOT NULL,
	[Rendicion_porcentaje] [numeric](18, 2) NOT NULL)
GO

-------------------------------------------------------------------------------------------------
-- TABLE FACTURA
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Factura](
	[Factura_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Factura_fecha] [datetime] NOT NULL,
	[Factura_total] [numeric](18, 2) NOT NULL,
	[Factura_fecha_venc] [datetime] NOT NULL,
	[Factura_empresa] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Empresa(Empresa_codigo),
	[Factura_cliente] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Cliente(Cliente_codigo),
	[Factura_rendicion] [numeric](18, 0) NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Rendicion(Rendicion_codigo),
	[Factura_habilitada] [bit] NOT NULL DEFAULT 1)
GO

-------------------------------------------------------------------------------------------------
-- TABLE ITEM_FACTURA
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Item_Factura](
	[ItemFactura_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[ItemFactura_factura][numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Factura(Factura_codigo),
	[ItemFactura_cantidad] [numeric](18, 0) NOT NULL,
	[ItemFactura_monto] [numeric](18, 2) NOT NULL)
GO

-------------------------------------------------------------------------------------------------
-- TABLE DEVOLUCION
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Devolucion](
	[Devolucion_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Devolucion_motivo] [nvarchar](255) NULL,
	[Devolucion_monto] [numeric](18, 2) NOT NULL,
	[Devolucion_factura] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Factura(Factura_codigo))
GO
-------------------------------------------------------------------------------------------------
-- TABLE FORMA_PAGO
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Forma_Pago](
	[FormaPago_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[FormaPago_descripcion] [nvarchar](50) NOT NULL)
GO

-------------------------------------------------------------------------------------------------
-- TABLE PAGO
-------------------------------------------------------------------------------------------------

CREATE TABLE [LORDS_OF_THE_STRINGS_V2].[Pago](
	[Pago_codigo] [numeric](18, 0) IDENTITY PRIMARY KEY,
	[Pago_fecha] [datetime] NOT NULL,
	[Pago_importe] [numeric](18, 2) NOT NULL,
	[Pago_sucursal] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Sucursal(Sucursal_codigo),
	[Pago_forma_pago] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Forma_Pago(FormaPago_codigo),
	[Pago_factura] [numeric](18, 0) NOT NULL FOREIGN KEY REFERENCES [LORDS_OF_THE_STRINGS_V2].Factura(Factura_codigo))
GO












-------------------------------------------------------------------------------------------------
-------------------------------- MIGRACIÓN DE DATOS----------------------------------------------
-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
--INSERTA EN LA TABLA ROL LOS VALORES DE LOS DISTINTOS TIPOS DE ROL.
-- Administradores - Cobradores 
-- Habilitado: 1 (True)
-- Habilitado: 0 (False)
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rol(Rol_nombre)
VALUES ('Administrador'),('Cobrador'); 
GO
-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA FUNCIONALIDAD  LOS DISTINTOS TIPOS DE FUNCIONALIDAD.
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad(Func_nombre)
VALUES ('ABM_ROL'), ('REGISTRO_USUARIO'),('ABM_CLIENTE'),('ABM_EMPRESA'),('ABM_SUCURSAL'),('ABM_FACTURAS'),('REGISTRO_PAGOS'),('RENDICION_FACTURAS'),('DEVOLUCION_FACTURAS'),('LISTADO_ESTADISTICO');
GO
-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA FUNCIONALIDAD_ROL LOS DISTINTOS TIPOS DE FUNCIONALIDAD DE CADA ROL.
-------------------------------------------------------------------------------------------------
------------- EL ROL ADMINISTRADOR (1) TIENE TODAS LAS FUNCIONALIDADES
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol(FuncRol_rol, FuncRol_func)
SELECT DISTINCT 1,
				Func_codigo
				FROM [LORDS_OF_THE_STRINGS_V2].Funcionalidad
GO
------------------------------------------------------------------------------------------------
----------- EL ROL COBRADOR (2) TIENE LAS SIGUIENTES FUNCIONALIDADES:
-----------  REGISTRO_PAGOS, RENDICION_FACTURAS, DEVOLUCION_FACTURAS, LISTADO_ESTADISTICO
------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol(
				FuncRol_rol, 
				FuncRol_func
				)
SELECT DISTINCT
				2,
				Func_codigo
FROM GD2C2017.LORDS_OF_THE_STRINGS_V2.Funcionalidad
WHERE Func_nombre = 'REGISTRO_PAGOS'
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol(
				FuncRol_rol, 
				FuncRol_func
				)
SELECT DISTINCT
				2,
				Func_codigo
FROM GD2C2017.LORDS_OF_THE_STRINGS_V2.Funcionalidad
WHERE Func_nombre = 'RENDICION_FACTURAS'
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol(
				FuncRol_rol, 
				FuncRol_func
				)
SELECT DISTINCT
				2,
				Func_codigo
FROM GD2C2017.LORDS_OF_THE_STRINGS_V2.Funcionalidad
WHERE Func_nombre = 'DEVOLUCION_FACTURAS'
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol(
				FuncRol_rol, 
				FuncRol_func
				)
SELECT DISTINCT
				2,
				Func_codigo
FROM GD2C2017.LORDS_OF_THE_STRINGS_V2.Funcionalidad
WHERE Func_nombre = 'LISTADO_ESTADISTICO'
GO
-----------------------------------------------------------------------------------
--INSERTA EN LA TABLA USUARIO MANUALMENTE LOS CAMPOS DEL USUARIO DE ROL ADMIN
-----------------------------------------------------------------------------------

DECLARE @pass [nvarchar](255)
SET @pass = 'w23e'

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Usuario(Usuario_username, Usuario_password)
VALUES ('admin', HASHBYTES('SHA2_256', @pass))
GO
--Rol Administrador (1)
INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rol_Usuario(RolUsua_usuario, RolUsua_rol)
VALUES (1,1)
GO
-----------------------------------------------------------------------------------
--INSERTA EN LA TABLA USUARIO MANUALMENTE LOS CAMPOS DEL USUARIO DE ROL COBRADOR
-- ------------------------------------------------------------------------------

DECLARE @pass [nvarchar](255)
SET @pass = '12345'

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Usuario(Usuario_username, Usuario_password)
VALUES ('cobrador', HASHBYTES('SHA2_256', @pass))
GO
-- Rol Cobrador (2)
INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rol_Usuario(RolUsua_usuario, RolUsua_rol)
VALUES (2,2)
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA CLIENTE
-------------------------------------------------------------------------------------------------
--HAY DOS MAILS REPETIDOS CON DIFERENTES DNI 
-- (31294365 con 54053910) y (2592862 con 3703799)

/*
SELECT DISTINCT [Cliente_Mail], [Cliente-Dni], [Cliente-Nombre],[Cliente-Apellido] Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Fecha_Nac]
FROM GD2C2017.gd_esquema.Maestra
WHERE [Cliente-Dni] IN (31294365, 54053910, 2592862, 3703799)
*/

UPDATE GD2C2017.gd_esquema.Maestra Set Cliente_Mail = 'ALBANAÁlvarez2@gmail.com' WHERE [Cliente-Dni] = 54053910
GO
UPDATE GD2C2017.gd_esquema.Maestra Set Cliente_Mail = 'DAILAMoreno2@gmail.com' WHERE [Cliente-Dni] = 3703799
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Cliente(
				Cliente_dni,
				Cliente_nombre, 
				Cliente_apellido, 
				Cliente_fecha_nac, 
				Cliente_mail,
				Cliente_direccion,
				Cliente_codigo_postal
			 )

SELECT DISTINCT
				m.[Cliente-Dni],
				m.[Cliente-Nombre], 
				m.[Cliente-Apellido], 
				m.[Cliente-Fecha_Nac],
				m.Cliente_Mail,
				m.Cliente_Direccion,
				m.Cliente_Codigo_Postal
FROM GD2C2017.gd_esquema.Maestra m
WHERE m.[Cliente-Dni] IS NOT NULL
GO

/*SELECT Cliente_Mail, COUNT(*) 
FROM
(SELECT DISTINCT [Cliente-Dni], Cliente_Mail
FROM GD2C2017.gd_esquema.Maestra) as FF
GROUP BY Cliente_Mail
HAVING COUNT(*) > 1*/
-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA RUBRO
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rubro(
                Rubro_descripcion
 )
SELECT DISTINCT
				m.Rubro_Descripcion
FROM GD2C2017.gd_esquema.Maestra m
WHERE m.Rubro_Descripcion IS NOT NULL
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA EMPRESA
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Empresa(
				Empresa_cuit,
				Empresa_nombre,
				Empresa_direccion
 )
SELECT DISTINCT
				m.Empresa_Cuit,
				m.Empresa_Nombre,
				m.Empresa_Direccion

FROM GD2C2017.gd_esquema.Maestra m
WHERE m.Empresa_Cuit IS NOT NULL
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA SUCURSAL
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Sucursal(
				Sucursal_nombre,
				Sucursal_direccion,
				Sucursal_codigo_postal
 )
SELECT DISTINCT
				m.Sucursal_Nombre,
				m.Sucursal_Dirección,
				CONVERT([nvarchar](255),m.Sucursal_Codigo_Postal)

FROM GD2C2017.gd_esquema.Maestra m
WHERE m.Sucursal_Nombre IS NOT NULL
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA USUARIO_SUCURSAL LAS DISTINTAS SUCURSALES DE CADA USUARIO.
-------------------------------------------------------------------------------------------------
------------- EL USUARIO ADMIN (1) TIENE TODAS LAS SUCURSALES
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Usuario_Sucursal(UsuarioSucur_usuario, UsuarioSucur_sucursal)
SELECT DISTINCT 1,
				Sucursal_codigo
				FROM [LORDS_OF_THE_STRINGS_V2].Sucursal
GO

------------------------------------------------------------------------------------------------
----------- EL USUARIO COBRADOR (2) NO TIENE SUCURSALES
-----------  
------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA RUBRO_EMPRESA
-------------------------------------------------------------------------------------------------

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rubro_Empresa(
				RubroEmpr_empresa,
				RubroEmpr_rubro
 )
SELECT DISTINCT
				e.Empresa_codigo,
				r.Rubro_codigo
FROM GD2C2017.gd_esquema.Maestra m
	JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Empresa e 
	ON e.Empresa_cuit = m.Empresa_Cuit
	JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Rubro r
	ON r.Rubro_descripcion = m.Rubro_Descripcion
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA RENDICION
-------------------------------------------------------------------------------------------------
--Curious fact: Todas impares son
SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Rendicion ON
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Rendicion(
				Rendicion_codigo,
				Rendicion_fecha,
				Rendicion_importe,
				Rendicion_porcentaje
 )
SELECT DISTINCT
				m.Rendicion_Nro,
				m.Rendicion_Fecha,
				m.ItemRendicion_Importe,
				ROUND((m.ItemRendicion_Importe/m.Factura_Total*100), 2)
FROM GD2C2017.gd_esquema.Maestra m
WHERE m.Rendicion_Nro IS NOT NULL

/* TODO: VER
SELECT DISTINCT
				m.Rendicion_Nro,
				m.Rendicion_Fecha,
				m.ItemRendicion_Importe
FROM GD2C2017.gd_esquema.Maestra m
WHERE m.Rendicion_Nro IS NOT NULL
GO
*/

SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Rendicion OFF
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA FACTURA
-------------------------------------------------------------------------------------------------

SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Factura ON
GO

-- Inserto las Facturas con Rendición primero

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Factura(
				Factura_codigo,
				Factura_fecha,
				Factura_fecha_venc, 
				Factura_total, 
				Factura_empresa, 
				Factura_cliente, 
				Factura_rendicion
)
SELECT DISTINCT 
				m.Nro_Factura,
				m.Factura_Fecha, 
				m.Factura_Fecha_Vencimiento, 
				m.Factura_Total, 
				e.Empresa_codigo, 
				c.Cliente_codigo, 
				m.Rendicion_Nro
FROM GD2C2017.gd_esquema.Maestra m

JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Empresa e
		ON e.Empresa_cuit = m.Empresa_cuit
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Cliente c
		ON c.Cliente_dni = m.[Cliente-Dni]
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Rendicion r
		ON r.Rendicion_codigo = m.Rendicion_Nro -- Aca no puede ser NULL la Rendicion
GO

-- Luego las Facturas restantes

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Factura(
				Factura_codigo,
				Factura_fecha,
				Factura_fecha_venc, 
				Factura_total, 
				Factura_empresa, 
				Factura_cliente, 
				Factura_rendicion
)
SELECT DISTINCT m.Nro_Factura,
				m.Factura_Fecha, 
				m.Factura_Fecha_Vencimiento, 
				m.Factura_Total, 
				e.Empresa_codigo, 
				c.Cliente_codigo, 
				m.Rendicion_Nro
FROM GD2C2017.gd_esquema.Maestra m
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Empresa e
		ON e.Empresa_cuit = m.Empresa_cuit
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Cliente c
		ON c.Cliente_dni = m.[Cliente-Dni]
WHERE NOT EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura f WHERE (f.Factura_codigo = m.Nro_Factura))
GO

SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Factura OFF
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA FORMA_PAGO
-------------------------------------------------------------------------------------------------


INSERT INTO [LORDS_OF_THE_STRINGS_V2].Forma_Pago(
				FormaPago_descripcion
)
SELECT DISTINCT 
				FormaPagoDescripcion
FROM GD2C2017.gd_esquema.Maestra
WHERE FormaPagoDescripcion IS NOT NULL
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA ITEM_FACTURA
-------------------------------------------------------------------------------------------------


INSERT INTO [LORDS_OF_THE_STRINGS_V2].Item_Factura(
					ItemFactura_factura, 
					ItemFactura_cantidad, 
					ItemFactura_monto
)
SELECT DISTINCT 
					m.Nro_Factura, 
					m.ItemFactura_Cantidad, 
					m.ItemFactura_Monto
FROM GD2C2017.LORDS_OF_THE_STRINGS_V2.Factura f
JOIN GD2C2017.gd_esquema.Maestra m
		ON f.Factura_codigo = m.Nro_Factura
WHERE f.Factura_codigo IS NOT NULL
GO

-------------------------------------------------------------------------------------------------
-- INSERTA EN LA TABLA PAGO
-------------------------------------------------------------------------------------------------

SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Pago ON
GO

INSERT INTO [LORDS_OF_THE_STRINGS_V2].Pago(
					Pago_codigo, 
					Pago_fecha, 
					Pago_importe, 
					Pago_sucursal, 
					Pago_forma_pago, 
					Pago_factura
) 
SELECT DISTINCT  
					m.Pago_nro, 
					m.Pago_Fecha, 
					m.Total,
					s.Sucursal_codigo, 
					fp.FormaPago_codigo, 
					m.Nro_Factura
FROM GD2C2017.gd_esquema.Maestra m 
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Factura f 
		ON m.Nro_Factura = f.Factura_codigo
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Sucursal s 
		ON s.Sucursal_codigo_postal = m.Sucursal_Codigo_Postal
JOIN GD2C2017.LORDS_OF_THE_STRINGS_V2.Forma_Pago fp 
		ON m.FormaPagoDescripcion = fp.FormaPago_descripcion
WHERE Pago_nro IS NOT NULL
GO

SET IDENTITY_INSERT [LORDS_OF_THE_STRINGS_V2].Pago OFF
GO

----------------------------------------------------------------------------------------------------
-----------------------------------CREACIÓN DE FUNCTIONS--------------------------------------------

----------------------------------------------------------------------------------------------------
-- LOGIN
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_is_blocked_user ') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_is_blocked_user];
GO
-- ROL
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_get_roles_usuario') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_get_roles_usuario]; 
GO
-- FUNCIONALIDAD
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_get_funcionalidades_rol') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_get_funcionalidades_rol]; 
GO
-- SUCURSAL
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_get_sucursales_usuario') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_get_sucursales_usuario]; 
GO
-- FACTURA
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_estado_factura') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_estado_factura]; 
GO
-- RENDICIÓN
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_es_empresa_rendida_este_mes') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_es_empresa_rendida_este_mes];
GO
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_es_empresa_rendida_mes_especifico') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_es_empresa_rendida_mes_especifico]; 
GO
-- REGISTRO DE PAGOS
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].fn_puede_pagar_factura') IS NOT NULL DROP FUNCTION [LORDS_OF_THE_STRINGS_V2].[fn_puede_pagar_factura];
GO
-------------------------------------------------------------------------------------------------
-- LOGIN
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_IS_BLOCKED_USER
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_is_blocked_user(@username nvarchar(50))
RETURNS bit
AS
 BEGIN
	IF ((SELECT Usuario_cant_intentos FROM [LORDS_OF_THE_STRINGS_V2].Usuario WHERE Usuario_username = @username) >= 3)
		RETURN 1
	RETURN 0
 END	
GO
-------------------------------------------------------------------------------------------------
-- ROL
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_GET_ROLES_USUARIO
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_get_roles_usuario(@username nvarchar(50))
RETURNS table
AS
	 RETURN (SELECT Rol_codigo, Rol_nombre, Rol_habilitado FROM [LORDS_OF_THE_STRINGS_V2].Rol
             JOIN [LORDS_OF_THE_STRINGS_V2].Rol_Usuario ON (Rol_codigo = RolUsua_rol) 
             JOIN [LORDS_OF_THE_STRINGS_V2].Usuario ON (Usuario_codigo = RolUsua_usuario)
             WHERE Usuario_username = @username AND Rol_habilitado = 1)
GO
-------------------------------------------------------------------------------------------------
-- FUNCIONALIDAD
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_GET_FUNCIONALIDADES_ROL
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_get_funcionalidades_rol(@rol_id numeric(18, 0))
RETURNS table
AS
	 RETURN (SELECT Func_codigo, Func_nombre FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad
             JOIN [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol ON (Func_codigo = FuncRol_func) 
             JOIN [LORDS_OF_THE_STRINGS_V2].Rol ON (Rol_codigo = FuncRol_rol)
             WHERE Rol_codigo = @rol_id)
GO
-------------------------------------------------------------------------------------------------
-- SUCURSAL
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_GET_SUCURSALES_USUARIO
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_get_sucursales_usuario(@user_id numeric(18, 0))
RETURNS table
AS
	 RETURN (SELECT Sucursal_codigo, Sucursal_nombre, Sucursal_direccion, Sucursal_codigo_postal, Sucursal_habilitada FROM LORDS_OF_THE_STRINGS_V2.Sucursal
             JOIN [LORDS_OF_THE_STRINGS_V2].Usuario_Sucursal ON (Sucursal_codigo = UsuarioSucur_sucursal)
             JOIN [LORDS_OF_THE_STRINGS_V2].Usuario ON (Usuario_codigo = UsuarioSucur_usuario)
             WHERE Usuario_codigo = @user_id AND Sucursal_habilitada = 1)
GO
-------------------------------------------------------------------------------------------------
-- FACTURA
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_ESTADO_FACTURA
-------------------------------------------------------------------------------------------------
-- 0 Está inhabilitada 
-- 1 No esta paga (o fue devuelta) => no está rendida => puede pagar
-- 2 Está paga y no rendida 
-- 3 Está paga y rendida
-- 4 Factura inexistente
-- 5 Error

CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_estado_factura(@idFactura numeric(18,0)) 	
RETURNS numeric (18, 0)
AS 
BEGIN 	
	IF NOT EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_codigo = @idFactura)
		RETURN 4 -- 4 Factura inexistente

	IF ((SELECT Factura_habilitada FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_codigo = @idFactura) = 0)
		RETURN 0 -- 0 Está inhabilitada
	
	IF NOT EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Pago WHERE Pago_factura = @idFactura)
		RETURN 1 -- 1 No esta paga (o fue devuelta) => no está rendida => puede pagar
	
	IF (((SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Pago JOIN LORDS_OF_THE_STRINGS_V2.Factura ON (Pago_factura = Factura_codigo)
		 WHERE Pago_factura = @idFactura) <=
		 (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Devolucion WHERE Devolucion_factura = @idFactura)))
			RETURN 1 -- 1 No esta paga (o fue devuelta) => no está rendida => puede pagar
	ELSE 
		BEGIN
			IF EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_codigo = @idFactura AND Factura_rendicion IS NULL)
				RETURN 2 -- Pagó y no se rindió la factura
			ELSE
				RETURN 3 -- Pagó y se rindió la factura
		END
RETURN 5
END
GO
-------------------------------------------------------------------------------------------------
-- RENDICIÓN
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_ES_EMPRESA_RENDIDA_ESTE_MES
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_es_empresa_rendida_este_mes(@id_empresa numeric(18,0))
RETURNS bit
AS
BEGIN
IF EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura 
			JOIN LORDS_OF_THE_STRINGS_V2.Rendicion R ON Factura_rendicion = Rendicion_codigo 
			WHERE Factura_empresa = @id_empresa AND MONTH(R.Rendicion_fecha) = MONTH(GETDATE()) AND YEAR(R.Rendicion_fecha) = YEAR(GETDATE()))
			RETURN 1

RETURN 0
END
GO
-------------------------------------------------------------------------------------------------
-- RENDICIÓN
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_ES_EMPRESA_RENDIDA_ESTE_MES
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_es_empresa_rendida_mes_especifico(@id_empresa numeric(18,0), @mes numeric(2,0), @anio numeric(5,0))
RETURNS bit
AS
BEGIN
IF EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura 
			JOIN LORDS_OF_THE_STRINGS_V2.Rendicion R ON Factura_rendicion = Rendicion_codigo 
			WHERE Factura_empresa = @id_empresa AND MONTH(R.Rendicion_fecha) = @mes AND YEAR(R.Rendicion_fecha) = @anio)
			RETURN 1

RETURN 0
END
GO
-------------------------------------------------------------------------------------------------
-- REGISTRO DE PAGOS
-------------------------------------------------------------------------------------------------
-- FUNCTION FN_PUEDE_PAGAR_FACTURA
-------------------------------------------------------------------------------------------------
CREATE FUNCTION [LORDS_OF_THE_STRINGS_V2].fn_puede_pagar_factura(@idFactura numeric(18,0)) 	
RETURNS bit 
AS 
BEGIN
IF NOT EXISTS (SELECT * FROM LORDS_OF_THE_STRINGS_V2.Factura 
			   JOIN LORDS_OF_THE_STRINGS_V2.Empresa ON (Factura_empresa = Empresa_codigo) 
			   WHERE Factura_codigo = @idFactura AND Factura_fecha_venc > GETDATE() AND Empresa_habilitada = 1 AND Factura_rendicion IS NULL)
	RETURN 0 -- 0 Fecha vencimiento no es mayor a la actual y/o la empresa no está habilitada y/o fue rendida

IF ((SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Pago JOIN LORDS_OF_THE_STRINGS_V2.Factura ON (Pago_factura = Factura_codigo) 
		 WHERE Pago_factura = @idFactura) <=
		 (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Devolucion WHERE Devolucion_factura = @idFactura))
			RETURN 1 -- 1 No esta paga (o fue devuelta) => puede pagar

RETURN 0
END
GO
------------------------------------------------------------------------------------------------------------
-----------------------------------CREACIÓN DE STORED PROCEDURES--------------------------------------------

------------------------------------------------------------------------------------------------------------
-- LOGIN
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].sp_login_validate') IS NOT NULL DROP PROCEDURE [LORDS_OF_THE_STRINGS_V2].[sp_login_validate]; 
GO
-- ROL
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].sp_baja_rol') IS NOT NULL DROP PROCEDURE [LORDS_OF_THE_STRINGS_V2].[sp_baja_rol]; 
GO
-- EMPRESA
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].sp_baja_empresa') IS NOT NULL DROP PROCEDURE [LORDS_OF_THE_STRINGS_V2].[sp_baja_empresa]; 
GO
-- SUCURSAL
IF OBJECT_ID('[LORDS_OF_THE_STRINGS_V2].sp_baja_sucursal') IS NOT NULL DROP PROCEDURE [LORDS_OF_THE_STRINGS_V2].[sp_baja_sucursal]; 
GO

-------------------------------------------------------------------------------------------------
-- LOGIN
-------------------------------------------------------------------------------------------------
-- PROCEDURE SP_LOGIN_VALIDATE
-------------------------------------------------------------------------------------------------
CREATE PROCEDURE [LORDS_OF_THE_STRINGS_V2].sp_login_validate(@username nvarchar(50) , @password nvarchar(255))
AS
 BEGIN
	IF ((SELECT LORDS_OF_THE_STRINGS_V2.fn_is_blocked_user(@username)) = 1)
			RETURN -2 /*Usuario bloqueado*/
 	DECLARE @hash nvarchar(255)
	DECLARE @user_id numeric(18,0)

	SET @hash = HASHBYTES('SHA2_256', @password)
	SET @user_id = (SELECT Usuario_codigo FROM [LORDS_OF_THE_STRINGS_V2].Usuario WHERE Usuario_username = @username AND Usuario_password = @hash)

	IF (@user_id IS NOT NULL)
		BEGIN 
		UPDATE [LORDS_OF_THE_STRINGS_V2].Usuario SET Usuario_cant_intentos = 0 WHERE Usuario_username = @username
		RETURN @user_id /*Usuario ok*/
		END
	ELSE 	
		BEGIN 
		UPDATE [LORDS_OF_THE_STRINGS_V2].Usuario SET Usuario_cant_intentos = Usuario_cant_intentos + 1 WHERE Usuario_username=@username
		RETURN -1 /*Usuario o Contraseña incorrecta*/
		END
END
GO
-------------------------------------------------------------------------------------------------
-- ROL
-------------------------------------------------------------------------------------------------
-- PROCEDURE SP_BAJA_ROL
-------------------------------------------------------------------------------------------------
CREATE PROCEDURE [LORDS_OF_THE_STRINGS_V2].sp_baja_rol(@id_rol numeric(18, 0))
AS
 BEGIN
	UPDATE [LORDS_OF_THE_STRINGS_V2].Rol SET Rol_habilitado = ~Rol_habilitado WHERE Rol_codigo=@id_rol /*Invierto estado*/
	DELETE FROM [LORDS_OF_THE_STRINGS_V2].Rol_Usuario WHERE RolUsua_rol=@id_rol
	DELETE FROM [LORDS_OF_THE_STRINGS_V2].Funcionalidad_Rol WHERE FuncRol_rol=@id_rol
END
GO
-------------------------------------------------------------------------------------------------
-- EMPRESA
-------------------------------------------------------------------------------------------------
-- PROCEDURE SP_BAJA_EMPRESA
-------------------------------------------------------------------------------------------------
CREATE PROCEDURE [LORDS_OF_THE_STRINGS_V2].sp_baja_empresa(@id_empresa numeric(18, 0))
AS
 BEGIN
	IF EXISTS (SELECT * FROM [LORDS_OF_THE_STRINGS_V2].Factura WHERE Factura_empresa = @id_empresa AND Factura_rendicion IS NULL)
		RETURN 0 /*Hay facturas pendientes de rendicion*/
	ELSE 	
		BEGIN
		UPDATE [LORDS_OF_THE_STRINGS_V2].Empresa SET Empresa_habilitada = ~Empresa_habilitada WHERE Empresa_codigo = @id_empresa /*Invierto estado*/
		RETURN 1
		END
END
GO
-------------------------------------------------------------------------------------------------
-- SUCURSAL
-------------------------------------------------------------------------------------------------
-- PROCEDURE SP_BAJA_SUCURSAL
-------------------------------------------------------------------------------------------------
CREATE PROCEDURE [LORDS_OF_THE_STRINGS_V2].sp_baja_sucursal(@id_sucursal numeric(18, 0))
AS
 BEGIN
	UPDATE [LORDS_OF_THE_STRINGS_V2].Sucursal SET Sucursal_habilitada = ~Sucursal_habilitada WHERE Sucursal_codigo = @id_sucursal /*Invierto estado*/
	DELETE FROM [LORDS_OF_THE_STRINGS_V2].Usuario_Sucursal WHERE UsuarioSucur_sucursal=@id_sucursal
	RETURN 1
END
GO


-------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------
-- PRUEBAS VARIAS
-------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------
