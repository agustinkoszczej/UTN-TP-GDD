using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace PagoAgilFrba.Utilidades
{
    public static class Utils
    {
        public static bool cumple_campos_obligatorios(List<Control> campos, ErrorProvider e)
        {
            campos.ForEach(c => campo_cumple(c, e));
            bool rta = campos.All(c => campo_cumple(c, e));

            if (!rta)
            {
                MessageBox.Show("Hay campos incompletos.", "Error campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rta;
        }

        public static bool esCampoVacio(Control campo, ErrorProvider e)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                //campo.Focus();
                e.SetError(campo, "Campo obligatorio");
                return true;
            }
            else
            {
                e.SetError(campo, null);
                return false;
            }
        }

        public static bool campo_cumple(Control c, ErrorProvider e)
        {
            bool cumple = true;
            bool es_chklist = false;

            var tbox = c as TextBox;
            var chkList = c as CheckedListBox;
            var combo = c as ComboBox;
            var numUpDown = c as NumericUpDown;
            var lBox = c as ListBox;

            if (tbox != null)
                cumple = !esCampoVacio(tbox, e);

            if (chkList != null)
            {
                cumple = chkList.CheckedItems.Count > 0;
                es_chklist = true;

                if (!cumple)
                {
                    chkList.Focus();
                    e.SetError(chkList, "Seleccione por lo menos un item");
                }
                else
                {
                    e.SetError(chkList, null);
                }
            }

            if (combo != null)
                cumple = !esCampoVacio(combo, e);

            if (numUpDown != null)
            {
                cumple = numUpDown.Value > 0;

                if (!cumple)
                {
                    numUpDown.Focus();
                    e.SetError(numUpDown, "Ingrese un monto o cantidad");
                }
                else
                {
                    e.SetError(numUpDown, null);
                }
            }

            if ((lBox != null) && (!es_chklist))
            {
                cumple = lBox.SelectedItem != null;

                if (!cumple)
                {
                    lBox.Focus();
                    e.SetError(lBox, "Seleccione un item");
                }
                else
                {
                    e.SetError(lBox, null);
                }
            }
            return cumple;
        }

       public static void cerrar_sesion()
        {
            if (MessageBox.Show("¿Está ud. seguro de querer cerrar sesión de PagoAgilFrba?", "Salir de PagoAgilFrba", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
       public static void limpiar_controles(List<Control> controles)
       {
           foreach (Control c in controles)
           {
               var tbox = c as TextBox;
               var combo = c as ComboBox;
               var table = c as DataGridView;
               var calen = c as DateTimePicker;
               var check = c as CheckBox;
               var chkList = c as CheckedListBox;
               var numUpDown = c as NumericUpDown;

               if (tbox != null)
               {
                   tbox.Text = string.Empty;
               }

               if (combo != null)
               {
                   combo.SelectedIndex = -1;
               }

               if ((table != null) && (table.DataSource != null))
               {
                   (table.DataSource as DataTable).Clear();
                   table.DataSource = null;
               }

               if (calen != null)
               {
                   // TODO: clear datetimepicker
               }

               if (check != null)
               {
                   check.Checked = false;
               }

               if (chkList != null)
               {
                   chkList.SelectedItems.Clear();
                   chkList.SelectedIndices.Clear();
                   descheckear_items(chkList);
               }

               if (numUpDown != null)
               {
                   numUpDown.Value = 0;
               }
           }
       }

       public static void solo_texto(KeyPressEventArgs e)
       {
           if (!char.IsLetter(e.KeyChar))
           {
               e.Handled = true;
           }
       }

       public static void descheckear_items(CheckedListBox items)
       {
           foreach (int i in items.CheckedIndices)
           {
               items.SetItemCheckState(i, CheckState.Unchecked);
           }
       }

       public static void posicionar_cursor_grilla_por_id(DataGridView grilla, int id)
       {
           grilla.Rows.OfType<DataGridViewRow>().Where(x => Convert.ToInt32(x.Cells["Código"].Value) == id).ToArray<DataGridViewRow>()[0].Selected = true;
       }

       public static void solo_numeros(KeyPressEventArgs e)
       {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
               e.Handled = true;
           }
       }
       public static string fechaACanonica(DateTime fecha)
       {
           int day = fecha.Day;
           int month = fecha.Month;
           int year = fecha.Year;

           string sDay;
           string sMonth;

           if (day < 10) sDay = "0" + day.ToString();
           else sDay = day.ToString();

           if (month < 10) sMonth = "0" + month.ToString();
           else sMonth = month.ToString();

           return year.ToString() + sMonth + sDay;
       }

       public static void clearDataGrid(DataGridView dataGrid)
       {
           dataGrid.DataSource = null;
           dataGrid.Rows.Clear();
       }
    }
}
