using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria redondeo
using System.Runtime.InteropServices;
//Referencia a Bibliotecas
using Capa_Datos;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        //--->Referencia a la clase Gestion_De_Usuario
        Gestion_De_Usuario usuario = new Gestion_De_Usuario();

        //--->Metodo de redondeo de esquina

        public Login()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //Boton cerrar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            var validacion = usuario.Login(txtusu.Text, txtcontr.Text);
            if (validacion == true) 
            {
                admin admi = new admin();
                //Ir al formulario
                admi.Show();
                //Cerrar Formulario Actual
                Hide();
            }
            else
            {
                MessageBox.Show("Error en Usuario y/o contraseña");
                txtcontr.Text = "";
                txtusu.Text = "";

            }
        }
    }
}
