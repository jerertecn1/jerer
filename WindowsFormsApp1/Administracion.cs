using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soportes;



namespace WindowsFormsApp1
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            Ocultar();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn());
            MensajePantalla();
            lblnombre.Text = Cache.Nombre;

            Menus();
        }

        //Crear metodo del menu

        public void Menus()
        {
            //Acciones
            picusu_admin.Visible = false;
            picventas_admin.Visible = false;
            picconfi_admin.Visible = false;
            picfactu_admin.Visible = false;
            picproveedores_admin.Visible = false;
            picproducto_admin.Visible = false;
        }
        //Al darle un click se abriran los iconos
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picusu_admin.Visible = true;
            picventas_admin.Visible = true;
            picconfi_admin.Visible = true;
            picfactu_admin.Visible = true;
            picproveedores_admin.Visible = true;
            picproducto_admin.Visible = true;
        }
        //Al hacer doble click se cerrara en menu
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            picusu_admin.Visible = false;
            picventas_admin.Visible = false;
            picconfi_admin.Visible = false;
            picfactu_admin.Visible = false;
            picproveedores_admin.Visible = false;
            picproducto_admin.Visible = false;
        }

        private void picusu_admin_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes();

            client.Show();

            Hide();
        }

        private void picventas_admin_Click(object sender, EventArgs e)
        {
            Ventas vent = new Ventas();

            vent.Show();

            Hide();
        }

        private void picproveedores_admin_Click(object sender, EventArgs e)
        {

        }

        private void picproducto_admin_Click(object sender, EventArgs e)
        {
            Productos product = new Productos();

            product.Show();

            Hide();
        }

        private void picfactu_admin_Click(object sender, EventArgs e)
        {

        }
    }
}
