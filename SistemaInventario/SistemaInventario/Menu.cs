using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace SistemaInventario
{
    public partial class Menu : Form
    {
        private IconButton current8tn;
        private Panel leftborderbtn;
        private Form fchild;
        public Menu()
        {
            InitializeComponent();

            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 58);
            flowLayoutPanel1.Controls.Add(leftborderbtn);
            this.Text=String.Empty; 
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct MyStruct
        {
            public static Color color1 = Color.FromArgb(2, 79, 181);
            public static Color color2 = Color.FromArgb(2, 96, 219);
            public static Color color3 = Color.FromArgb(3, 108, 245);
            public static Color color4 = Color.FromArgb(54, 123, 245);
            public static Color color5 = Color.FromArgb(48, 111, 219);

        }
        private void Activatebuttons(object senderbtn, Color color) {
            if (senderbtn != null) {
                disablebb();
                current8tn = (IconButton)senderbtn;
                current8tn.BackColor = Color.FromArgb(105, 45, 158);
                current8tn.ForeColor = Color.AntiqueWhite;
                current8tn.TextAlign = ContentAlignment.MiddleCenter;
                current8tn.IconColor = Color.AntiqueWhite;
                current8tn.IconSize = 34;
                current8tn.TextImageRelation = TextImageRelation.TextBeforeImage;
                current8tn.ImageAlign = ContentAlignment.BottomRight;
                // borde 
                leftborderbtn.BackColor = color;
                leftborderbtn.Location = new Point(0, current8tn.Location.Y);
                leftborderbtn.Visible = true;
                //leftborderbtn.BringToFront();
                iconPicturehome.IconChar=current8tn.IconChar;
                iconPicturehome.IconColor = Color.White;
            }


        }

        private void disablebb()
        {
            if (current8tn != null)
            {
                current8tn.IconSize = 37;
                current8tn.BackColor = Color.FromArgb(26, 22, 224);
                current8tn.ForeColor = Color.FromArgb(224, 189, 22);
                current8tn.TextAlign = ContentAlignment.MiddleLeft;
                current8tn.IconColor = Color.FromArgb(224, 189, 22);
                current8tn.TextImageRelation = TextImageRelation.ImageBeforeText;
                current8tn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }  
        public void abrirformo(Form child)
        {   // si queremos varias ventanas cerramos en el anterior 

            if (fchild != null)
            {
                fchild.Close();
            }
            fchild=child;   
            child.TopLevel = false;  
            child.FormBorderStyle= FormBorderStyle.None;    
            child.Dock= DockStyle.Fill; 
            panelhijo.Controls.Add(child);  
            panelhijo.Tag= child;
            child.BringToFront();
            child.Show();   
            txthome.Text=child.Text;    


        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icondelete_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size=Screen.PrimaryScreen.WorkingArea.Size;    

        }

        private void iconagregar_Click(object sender, EventArgs e)
        {
            Activatebuttons(sender, MyStruct.color3);
            abrirformo(new Agregainventario());
        }

        private void iconmod_Click(object sender, EventArgs e)
        {
            Activatebuttons(sender, MyStruct.color2);
            abrirformo(new Modificar());
        }

        private void iconver_Click(object sender, EventArgs e)
        {
            Activatebuttons(sender, MyStruct.color5);
            abrirformo(new Ver());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activatebuttons(sender, MyStruct.color4);
            abrirformo(new Eliminar());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activatebuttons(sender, MyStruct.color1);
            abrirformo(new Acerda());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            fchild.Close(); 

        }
        private void Reset() {

            disablebb();
            leftborderbtn.Visible = false;
            iconPicturehome.IconChar = IconChar.Home;
            iconPicturehome.IconColor = Color.Black;
            txthome.Text = "Home";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPicturxxx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPicturemini_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void panelhijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPicturehome_Click(object sender, EventArgs e)
        {

        }
    }
}

