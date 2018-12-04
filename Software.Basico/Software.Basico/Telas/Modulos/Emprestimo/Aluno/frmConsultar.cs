using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Emprestimo;
using Software.Basico.DB.Base;

namespace Software.Basico.Telas.Modulos.Emprestimo.Aluno
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
            CarregarGrid();
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

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            EmprestimoBusiness business = new EmprestimoBusiness();
            List<vw_emprestimo_aluno> emprestimos = business.ListarEmprestimosAlunos();

            dgvLivros.AutoGenerateColumns = false;
            dgvLivros.DataSource = emprestimos;
        }
    }
}
