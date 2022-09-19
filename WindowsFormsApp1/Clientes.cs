using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
//Referenciar la capa de datos
using Capa_Datos;
//Referenciamos la Capa de Soportes
using Soportes;

namespace WindowsFormsApp1
{
    //Referenciamos la capa de gestion de clientes
    
    public partial class Clientes : Form
    {
        Gestion_Clientes client = new Gestion_Clientes();
        //Llamamos a la calse Conexion_Auxiliar
        Conexion_Auxiliar con = new Conexion_Auxiliar();
        public Clientes()
        {
            InitializeComponent();
            ocultar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasBDDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.ventasBDDataSet.Clientes);

        }

        private void btnalta_clientes_Click(object sender, EventArgs e)
        {
            //Estructura de seleccion simple "IF/ELSE"

            //Verificar que los campos esten completos
            if (txtdni_clientes.Text == "" || txtnom_clientes.Text == "" || txttel_clientes.Text == "" || txtedad_clientes.Text == "" || comboBox_clientes.Text == "" || comboBox1_clientes.Text == "" || comboBox2_clientes.Text == "" || txtcp_clientes.Text == "" || txtsex_clientes.Text == "")
            {
                //or ---> ||
                //and ---> &&
                MessageBox.Show("Debe completar los campos para continuar");
            }
            else
            {
                client.NuevoCliente(Convert.ToInt32(txtdni_clientes.Text),txtnom_clientes.Text,Convert.ToInt32(txttel_clientes), Convert.ToInt32(txtedad_clientes),comboBox_clientes.Text,comboBox1_clientes.Text,comboBox2_clientes.Text,Convert.ToInt32(txtcp_clientes),txtsex_clientes.Text);
                MessageBox.Show("Se ha registrado el cliente correctamente");
            }
        }

        private void btnmod_clientes_Click(object sender, EventArgs e)
        {
            if (txtdni_clientes.Text == "" || txtnom_clientes.Text == "" || txttel_clientes.Text == "" || txtedad_clientes.Text == "" || comboBox_clientes.Text == "" || comboBox1_clientes.Text == "" || comboBox2_clientes.Text == "" || txtcp_clientes.Text == "" || txtsex_clientes.Text == "")
            {
                //or ---> ||
                //and ---> &&
                MessageBox.Show("Debe completar los campos para continuar");
            }
            else
            {
                client.ModificarCliente(Convert.ToInt32(txtdni_clientes.Text), txtnom_clientes.Text, Convert.ToInt32(txttel_clientes), Convert.ToInt32(txtedad_clientes), comboBox_clientes.Text, comboBox1_clientes.Text, comboBox2_clientes.Text, Convert.ToInt32(txtcp_clientes), txtsex_clientes.Text);
                MessageBox.Show("Se ha modificado el cliente correctamente");
            }
        }

        //Metodo para ocultar datos
        public void ocultar()
        {
            txtdni_clientes.Visible = false;

            txtnom_clientes.Visible = false;

            txtcp_clientes.Visible = false;

            txtedad_clientes.Visible = false;

            txtsex_clientes.Visible = false;

            txttel_clientes.Visible = false;

            comboBox_clientes.Visible = false;

            comboBox1_clientes.Visible = false;

            comboBox2_clientes.Visible = false;

            btnalta_clientes.Visible = false;

            btnmod_clientes.Visible = false;

            btnbuscar_clientes.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtdni_clientes.Text=="")
            {
                MessageBox.Show("Debe ingresar un DNI para continuar");
            }
            else
            {
                try
                {
                    client.EliminarCliente(Convert.ToInt32(txtdni_clientes.Text));
                    MessageBox.Show("Has eliminado correctamente el cliente");
                }
                //Catch captura errores y lo almacena en la variable "ex"
                catch(Exception ex)
                {
                    MessageBox.Show("Usuario no encontrado");
                    //Imprimimos el error via mensaje
                    MessageBox.Show("Error en", ex.ToString());
                }

            }
        }

        private void btnbuscar_clientes_Click(object sender, EventArgs e)
        {
            //--->Crear la consulta SQLServer
            SqlCommand cmd = new SqlCommand("select * from Clientes where DNI=@DNI",con.AbrirConexion());
            cmd.Parameters.AddWithValue("@DNI", txtdni_clientes.Text);
            //Buscamos los datos de la tabla de Sql asociados al campo clave "Ejecutamos la consulta"
            SqlDataReader Buscar = cmd.ExecuteReader();
            if (Buscar.Read())
            {
                //Traemos los campos de la base de datos a los textbox
                //Traemos al textbox= el dato de la BD "campo" convertido en una cadena
                txtnom_clientes.Text = Buscar["Nombre"].ToString();
                txttel_clientes.Text = Buscar["Telefono"].ToString();
                txtedad_clientes.Text = Buscar["Edad"].ToString();
                comboBox_clientes.Text = Buscar["Nacionalidad"].ToString();
                comboBox1_clientes.Text = Buscar["Provincia"].ToString();
                comboBox2_clientes.Text = Buscar["Localidad"].ToString();
                txtcp_clientes.Text = Buscar["CP"].ToString();
                txtsex_clientes.Text = Buscar["Sexo"].ToString();
                txtdni_clientes.Visible = true;

                txtnom_clientes.Visible = true;

                txtcp_clientes.Visible = true;

                txtedad_clientes.Visible = true;

                txtsex_clientes.Visible = true;

                txttel_clientes.Visible = true;

                comboBox_clientes.Visible = true;

                comboBox1_clientes.Visible = true;

                comboBox2_clientes.Visible = true;

                btnalta_clientes.Visible = true;

                btnmod_clientes.Visible = true;

                btnbuscar_clientes.Visible = true;

                btnmod_clientes.Visible = true;

                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");

                txtnom_clientes.Visible = true;

                txtcp_clientes.Visible = true;

                txtedad_clientes.Visible = true;

                txtsex_clientes.Visible = true;

                txttel_clientes.Visible = true;

                comboBox_clientes.Visible = true;

                comboBox1_clientes.Visible = true;

                comboBox2_clientes.Visible = true;

                btnalta_clientes.Visible = true;

                btnmod_clientes.Visible = true;

                btnbuscar_clientes.Visible = true;

                btnalta_clientes.Visible = true;
            }
            con.CerrarConexion();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
