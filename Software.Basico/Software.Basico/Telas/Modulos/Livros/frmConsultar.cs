using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Livros
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
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;

        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
