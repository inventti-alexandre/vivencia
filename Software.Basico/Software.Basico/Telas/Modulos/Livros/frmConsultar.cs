using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Livros;
using Software.Basico.DB.Base;

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
            frmCadastrar frm = new frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            LivroBusiness business = new LivroBusiness();
            List<tb_livro> livros = business.ListarLivros();

            dgvLivros.AutoGenerateColumns = false;
            dgvLivros.DataSource = livros;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tb_livro livro = dgvLivros.CurrentRow.DataBoundItem as tb_livro;

            frmCadastrar frm = new frmCadastrar();
            frm.PreencherCampos(livro.id_livro);
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
