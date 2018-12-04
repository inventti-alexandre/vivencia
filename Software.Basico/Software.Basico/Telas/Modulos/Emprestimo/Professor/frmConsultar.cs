using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Emprestimo.Professor
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnVisualizar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;
           
            btnVisualizar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
            btnListar.ForeColor = Tema.Texto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
          ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

            frmMenu frm = new frmMenu();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
