using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Autor
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
            pnTop.BackColor = Tema.Primaria;
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;

            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
            btnListar.ForeColor = Tema.Texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroAutor frm = new frmCadastroAutor();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
