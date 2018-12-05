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
using Software.Basico.DB.Emprestimo;

namespace Software.Basico.Telas.Modulos.Emprestimo.Aluno
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
            CarregarCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFuncionario.Clear();
            txtAluno.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtEmail.Clear();
            txtGenero.Clear();
            txtN.Clear();
            txtRA.Clear();
            txtTurma.Clear();
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnCancelar.BackColor = Tema.Segundaria;

            btnCancelar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
        }

        private void CarregarCombo()
        {
            LivroBusiness abusiness = new LivroBusiness();
            List<tb_livro> livros = abusiness.ListarLivros();

            cboLivro.ValueMember = nameof(tb_livro.id_livro);
            cboLivro.DisplayMember = nameof(tb_livro.ds_titulo);
            cboLivro.DataSource = livros;
        }

        private void Emprestimo()
        {
            tb_emprestimo emprestimo = new tb_emprestimo();
            emprestimo.bt_devolvido = false;
            emprestimo.ds_email = txtEmail.Text.Trim();
            emprestimo.dt_emprestimo = DateTime.Now;
            emprestimo.nm_funcionario = txtFuncionario.Text;
            emprestimo.dt_devolucao = Convert.ToDateTime(dtpDevolucao.Text);
            emprestimo.tb_livro_id_livro = Convert.ToInt32(cboLivro.SelectedValue);

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            emprestimos.CadastroNovoEmprestimo(emprestimo, txtRA.Text);            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRA.BackColor == Color.Green && txtRA.Text.Length == 9)
                    Emprestimo();
                else
                    throw new ArgumentException("RA inválido!");

                MessageBox.Show($"Cadastro efetuado com sucesso!", "Biblioteca",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmConsultar frm = new frmConsultar();
                ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Biblioteca",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtRA.Text.Length > 8)
                {
                    AzureBiblioteca db = new AzureBiblioteca();
                    tb_turma_aluno data = db.tb_turma_aluno.Where(x => x.cd_ra == txtRA.Text).ToList().Single();

                    if (data.nr_chamada != null)
                    {
                        txtRA.BackColor = Color.Green;

                        txtAluno.Text = data.tb_aluno.nm_aluno;
                        txtN.Text = data.nr_chamada.ToString();
                        txtTurma.Text = data.tb_turma.nm_turma;
                    }
                }
                else
                    txtRA.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("A sequência não contém elementos"))
                    txtRA.BackColor = Color.Red;
                else
                    MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TravarTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboLivro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_livro livro = cboLivro.SelectedItem as tb_livro;

                txtAutor.Text = livro.tb_autor.nm_autor;
                txtEditora.Text = livro.nm_editora;
                txtGenero.Text = livro.tb_genero.nm_genero;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
