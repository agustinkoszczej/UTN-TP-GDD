using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Funcionalidad
    {

        public int id { get; private set; }
        public string nombre { get; set; }

        public Funcionalidad(int _id, string _nombre)
        {
            this.id = _id;
            this.nombre = _nombre;
        }


        /*public Form get_form_funcionalidad(Funcionalidad funcionalidad, Login.menuFuncsRolUserForm parent)
        {
            Form formToReturn = null;

            if (funcionalidad == null)
                return null;

            switch (funcionalidad.id)
            {
                case 1:
                    Abm_Rol.ABMRolForm form1 = new Abm_Rol.ABMRolForm(parent);
                    formToReturn = form1 as Form;
                    break;
                case 2:
                    Abm_Cliente.ABMClienteForm form2 = new Abm_Cliente.ABMClienteForm(parent);
                    formToReturn = form2 as Form;
                    break;
                case 3:
                    Abm_Automovil.ABMAutomovilForm form3 = new Abm_Automovil.ABMAutomovilForm(parent);
                    formToReturn = form3 as Form;
                    break;
                case 4:
                    Abm_Turno.ABMTurnoForm form4 = new Abm_Turno.ABMTurnoForm(parent);
                    formToReturn = form4 as Form;
                    break;
                case 5:
                    Abm_Chofer.ABMChoferForm form5 = new Abm_Chofer.ABMChoferForm(parent);
                    formToReturn = form5 as Form;
                    break;
                case 6:
                    Registro_Viajes.RegistroViajeForm form6 = new Registro_Viajes.RegistroViajeForm(parent);
                    formToReturn = form6 as Form;
                    break;
                case 7:
                    Rendicion_Viajes.RendicionViajesForm form7 = new Rendicion_Viajes.RendicionViajesForm(parent);
                    formToReturn = form7 as Form;
                    break;
                case 8:
                    FacturacionClientesForm form8 = new FacturacionClientesForm(parent);
                    formToReturn = form8 as Form;
                    break;
                case 9:
                    Listado_Estadistico.ListadoEstadisticoForm form9 = new Listado_Estadistico.ListadoEstadisticoForm(parent);
                    formToReturn = form9 as Form;
                    break;
                default:
                    formToReturn = null;
                    break;
            }

            return formToReturn;
        }*/
    }
}
