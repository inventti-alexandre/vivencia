using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.APIs.Email;

namespace Software.Basico.Telas.SubTelas
{
    public partial class frmHome : UserControl
    {
        public frmHome()
        {
            InitializeComponent();
            TemaTela();
        }
        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
