using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void total()
        {
            int cantidad = Convert.ToInt32(txt_Cantidada.text);
            int precio = Convert.ToInt32(txt_Precio.text);
            int tot = (cantidad * precio);
            txt_Subtotal.texte = tot.ToString();
        }
        private void text_cantidad_textchanged(object sender, EventArgs e)
        {
            if(txt_Cantidad.text == "")
            {

            }
            else
            {
                total();
            }
        }

    }
}
