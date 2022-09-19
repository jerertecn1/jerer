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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnalta_prod_Click(object sender, EventArgs e)
        {
            //Estructura de seleccion simple "IF/ELSE"

            //Verificar que los campos esten completos
            if (txtcod_prod.Text == "" || txtnom_prod.Text == "" || txtcate_prod.Text == "" || txtprecio_prod.Text == "" || txtprov_prod.Text == "" || txtstock_prod.Text == "")
            {
                //or ---> ||
                //and ---> &&
                MessageBox.Show("Debe completar los campos para continuar");
            }
            else
            {
                client.NuevoCliente(Convert.ToInt32(txtdni_clientes.Text), txtnom_clientes.Text, Convert.ToInt32(txttel_clientes), Convert.ToInt32(txtedad_clientes), comboBox_clientes.Text, comboBox1_clientes.Text, comboBox2_clientes.Text, Convert.ToInt32(txtcp_clientes), txtsex_clientes.Text);
                MessageBox.Show("Se ha registrado el cliente correctamente");
            }
        }

        private void btnbaja_prod_Click(object sender, EventArgs e)
        {

        }
        public void total()
        {
            int cantidad=Convert.to
        }
    }
    }
}
