using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.SubTelas
{
    public partial class frmSobreNos : UserControl
    {
        public frmSobreNos()
        {
            InitializeComponent();
            TemaTela();
        }
        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSobreNos_Load(object sender, EventArgs e)
        {

        }
    }
}
