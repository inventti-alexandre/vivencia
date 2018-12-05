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

namespace Software.Basico.Telas.Modulos.Emprestimo.Professor
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            EmprestimoBusiness business = new EmprestimoBusiness();
            List<vw_emprestimo_locatario> emprestimo = business.ListarEmprestimosLocatarios(txtTitulo.Text.Trim(), txtProfessor.Text.Trim(), chkDevolvido.Checked);

            dgvEmprestimo.AutoGenerateColumns = false;
            dgvEmprestimo.DataSource = emprestimo;
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

    
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                vw_emprestimo_locatario locatario = dgvEmprestimo.CurrentRow.DataBoundItem as vw_emprestimo_locatario;

                EmprestimoBusiness business = new EmprestimoBusiness();
                business.RemoverEmprestimo(locatario.id_emprestimo);

                MessageBox.Show("Emprestimo removido com sucesso!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto"))
                    MessageBox.Show("Selecione um emprestimo!", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
