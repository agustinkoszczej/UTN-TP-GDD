using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.DAOs
{
    class ListadoEstadisticoDAO
    {
        public static void cargar_grilla_porcentaje_de_facturas(DataGridView grillaListado, int trimestre, string año)
        {
            string query = string.Format(@"SELECT TOP 5 e.Empresa_nombre,count(p.Pago_codigo)*100/count(*) as Porcentaje from [GD2C2017].[LORDS_OF_THE_STRINGS_V2].[Factura] f 
	                                left join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Pago p ON
		                                p.Pago_factura = f.Factura_codigo
	                                join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Empresa e ON
		                                e.Empresa_codigo = f.Factura_empresa
                                    where YEAR(f.Factura_fecha) = " + año +
                                        " AND MONTH(f.Factura_fecha) BETWEEN " + (4 * trimestre + 1) + " AND " + ((4 * trimestre + 1) + 3) +
                                    " group by e.Empresa_nombre, Factura_empresa order by Porcentaje desc");
            DBConnection.llenar_grilla(grillaListado, query);
        }

        public static void cargar_grilla_empresas_mayor_monto(DataGridView grillaListado, int trimestre, string año)
        {
            string query = string.Format(@"SELECT TOP 5 empresa_nombre, sum(rendicion_importe) as monto_rendido from LORDS_OF_THE_STRINGS_V2.Factura f
	                                inner join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Empresa e ON
		                                e.Empresa_codigo = f.Factura_empresa
	                                inner join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Rendicion r ON
		                                r.Rendicion_codigo = f.Factura_rendicion
	                                where YEAR(r.Rendicion_fecha) = " + año +
                                        " AND MONTH(r.Rendicion_fecha) BETWEEN " + (4 * trimestre + 1) + " AND " + ((4 * trimestre + 1) + 3) +
                                    " group by Empresa_nombre order by sum(rendicion_importe) desc");
            DBConnection.llenar_grilla(grillaListado, query);
        }

        public static void cargar_grilla_clientes_mas_pagos(DataGridView grillaListado, int trimestre, string año)
        {
            string query = string.Format(@"SELECT TOP 5 c.Cliente_codigo, c.Cliente_nombre, c.Cliente_apellido, c.Cliente_dni, count(p.Pago_codigo) as Cantidad_de_pagos
	                                from [GD2C2017].[LORDS_OF_THE_STRINGS_V2].[Factura] f 
	                                left join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Pago p ON
		                                p.Pago_factura = f.Factura_codigo
	                                join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Cliente c ON
		                                c.Cliente_codigo = f.Factura_cliente
                                    where YEAR(f.Factura_fecha) = " + año +
                                        " AND MONTH(f.Factura_fecha) BETWEEN " + (4 * trimestre + 1) + " AND " + ((4 * trimestre + 1) + 3) +
                                    " group by c.Cliente_codigo, c.Cliente_nombre, c.Cliente_apellido, c.Cliente_dni order by Cantidad_de_pagos desc");
            DBConnection.llenar_grilla(grillaListado, query);
        }

        public static void cargar_grilla_clientes_cumplidores(DataGridView grillaListado, int trimestre, string año)
        {
            string query = string.Format(@"SELECT TOP 5 c.Cliente_codigo, c.Cliente_nombre, c.Cliente_apellido, c.Cliente_dni, count(p.Pago_codigo)*100/count(*) as Porcentaje from [GD2C2017].[LORDS_OF_THE_STRINGS_V2].[Factura] f 
	                                left join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Pago p ON
		                                p.Pago_factura = f.Factura_codigo
	                                join [GD2C2017].[LORDS_OF_THE_STRINGS_V2].Cliente c ON
		                                c.Cliente_codigo = f.Factura_cliente
                                    where YEAR(f.Factura_fecha) = " + año +
                                        " AND MONTH(f.Factura_fecha) BETWEEN " + (4 * trimestre + 1) + " AND " + ((4 * trimestre + 1) + 3) +
                                    " group by c.Cliente_codigo, c.Cliente_nombre, c.Cliente_apellido, c.Cliente_dni order by Porcentaje desc");
            DBConnection.llenar_grilla(grillaListado, query);
        }
    }
}
