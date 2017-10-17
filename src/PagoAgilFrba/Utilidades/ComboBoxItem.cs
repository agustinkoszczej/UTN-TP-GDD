using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Utilidades
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string _text, object _value)
        {
            this.Text = _text;
            this.Value = _value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
    /*private void Test()
    {
                ComboBxItem item = new ComboBoxItem();
                item.Text = "Item text1";
                item.Value = 12;

                comboBox1.Items.Add(item);

                comboBox1.SelectedIndex = 0;

                MessageBox.Show((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
    }*/
}
