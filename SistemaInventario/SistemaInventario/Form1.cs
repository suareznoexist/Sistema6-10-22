using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocios;

namespace SistemaInventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }









        //metodo para cerrar el fomrluario
        private void formcl(object sender, FormClosingEventArgs e)
        {
            //LIMPIAR TEXBOX
            this.Show();
            txbID.Text = "";
            txbUsuario.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //BOTON DE INGRESAR
        private void btningresar_Click(object sender, EventArgs e)
        {
            // estos bptones se ponen solo cuando el usuario sea correcto
            splashscreen  so = new splashscreen();  
            so.ShowDialog();

            Menu menu = new Menu();


            menu.Show();
            Login login = new Login();
          
            //BOTON INGRESAR
            //VALIDAR 
            //LIMPIAR TEXBOX
            List<Usuarios> test = new CNUser().listaUsuarios();
            Usuarios ousuario = new CNUser().listaUsuarios().Where(u => u.Nameuser == txbUsuario.Text && u.IdUser == Convert.ToInt32(txbID.Text)).FirstOrDefault();
            if (ousuario != null)
            {
                MessageBox.Show("Se encuentra registrado en la base de datos");
                this.Hide();
                //Login fr = new Add(ousuario);
                //fr.Show();
                //fr.FormClosing += formcl;
                login.Close();
            }
            else
            {
                MessageBox.Show(" No se encuentra registrado");
             
                txbID.Text = "Contraseña";
                txbUsuario.Text = "Usuario";
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "Usuario")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "Usuario";
                txbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txbID_Enter(object sender, EventArgs e)
        {
            if (txbID.Text == "Contraseña")
            {
                txbID.Text = "";
                txbID.ForeColor = Color.LightGray;
                txbID.UseSystemPasswordChar = true;
            }
        }

        private void txbID_Leave(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                txbID.Text = "Contraseña";
                txbID.ForeColor = Color.Silver;
                txbID.UseSystemPasswordChar = false;
            }
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconinvitado_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
            splashscreen so = new splashscreen();
            so.ShowDialog();
            Menuinvitado menuinvitado = new Menuinvitado();
            
              
            menuinvitado.Show();
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
