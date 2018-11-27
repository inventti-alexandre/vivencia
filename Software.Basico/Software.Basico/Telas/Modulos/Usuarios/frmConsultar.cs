using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Usuarios
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();

            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
