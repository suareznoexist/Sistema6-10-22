
namespace SistemaInventario
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btningresar = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconinvitado = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(250)))));
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(237)))));
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(212)))));
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(230, 552);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(363, 65);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Inciar Sesion";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsuario.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.txbUsuario.Location = new System.Drawing.Point(253, 368);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUsuario.Multiline = true;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(313, 32);
            this.txbUsuario.TabIndex = 1;
            this.txbUsuario.Text = "Usuario";
            this.txbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            this.txbUsuario.Enter += new System.EventHandler(this.txbUsuario_Enter);
            this.txbUsuario.Leave += new System.EventHandler(this.txbUsuario_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 55);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(663, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "_____________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaInventario.Properties.Resources.logo_uenic_y_galileo_02_1_1024x311;
            this.pictureBox1.Location = new System.Drawing.Point(184, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconinvitado
            // 
            this.iconinvitado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconinvitado.FlatAppearance.BorderSize = 0;
            this.iconinvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconinvitado.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconinvitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(22)))));
            this.iconinvitado.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconinvitado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(22)))));
            this.iconinvitado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconinvitado.IconSize = 35;
            this.iconinvitado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconinvitado.Location = new System.Drawing.Point(310, 642);
            this.iconinvitado.Name = "iconinvitado";
            this.iconinvitado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconinvitado.Size = new System.Drawing.Size(237, 91);
            this.iconinvitado.TabIndex = 18;
            this.iconinvitado.Text = "Invitado";
            this.iconinvitado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconinvitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconinvitado.UseVisualStyleBackColor = true;
            this.iconinvitado.Click += new System.EventHandler(this.iconinvitado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(253, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "_____________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbID.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.LightGray;
            this.txbID.Location = new System.Drawing.Point(253, 450);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(313, 29);
            this.txbID.TabIndex = 2;
            this.txbID.Text = "Contraseña";
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            this.txbID.Enter += new System.EventHandler(this.txbID_Enter);
            this.txbID.Leave += new System.EventHandler(this.txbID_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "_____________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.iconinvitado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(189)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconinvitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
    }
}

