using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }
        private void btnVerComputadores_Click(object sender, EventArgs e)
        {
            switch (cbverCompus.SelectedIndex)
            {
                case 0://teclados

                    break;
                case 1://monitores

                    break;
                case 2: //mouses

                    break;
                case 3://cases   

                    break;


            }
        }

        private void Ver_Load(object sender, EventArgs e)
        {
            Anchor = AnchorStyles.None;

        }
    }
}
