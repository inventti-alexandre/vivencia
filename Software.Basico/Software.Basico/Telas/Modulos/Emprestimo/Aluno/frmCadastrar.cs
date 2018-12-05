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
            txtEmail.Clear();
            txtN.Clear();
            txtRA.Clear();
            txtTurma.Clear();
        }

        int id, idAluno;

        public void PreencherCampos(int idEmprestimo)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_emprestimo emprestimo = db.tb_emprestimo.Where(x => x.id_emprestimo == idEmprestimo).ToList().Single();

            cboLivro.SelectedItem = emprestimo.tb_livro_id_livro;
            txtN.Text = emprestimo.tb_turma_aluno.nr_chamada.ToString();
            txtRA.Text = emprestimo.tb_turma_aluno.cd_ra;
            txtFuncionario.Text = emprestimo.nm_funcionario;
            txtAluno.Text = emprestimo.tb_turma_aluno.tb_aluno.nm_aluno;
            id = emprestimo.id_emprestimo;
            chkDevolvido.Checked = emprestimo.bt_devolvido;
            dtpEmprestimo.Value = emprestimo.dt_emprestimo;
            dtpDevolucao.Value = emprestimo.dt_devolucao;
            txtTurma.Text = emprestimo.tb_turma_aluno.tb_turma.nm_turma;

            tb_aluno_dados dados = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == emprestimo.tb_turma_aluno_id_turma_aluno).ToList().Single();
            txtEmail.Text = dados.ds_email;
            idAluno = dados.id_aluno_dados;

            txtRA.Enabled = false;
            dtpEmprestimo.Enabled = false;
            dtpEmprestimo.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            chkDevolvido.Visible = true;
            label12.Visible = true;
            btnAlterar.Visible = true;
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnCancelar.BackColor = Tema.Segundaria;
            btnAlterar.BackColor = Tema.Segundaria;

            btnCancelar.ForeColor = Tema.Texto;
            btnAlterar.ForeColor = Tema.Texto;
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
            emprestimo.dt_emprestimo = DateTime.Now;
            emprestimo.nm_funcionario = txtFuncionario.Text;
            emprestimo.dt_devolucao = Convert.ToDateTime(dtpDevolucao.Text);
            emprestimo.tb_livro_id_livro = Convert.ToInt32(cboLivro.SelectedValue);

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            emprestimos.CadastroNovoEmprestimo(emprestimo, txtRA.Text, txtEmail.Text);            
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

                        CriarNotificacao(data);
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

        private void CriarNotificacao(tb_turma_aluno data)
        {
            try
            {
                AzureBiblioteca db = new AzureBiblioteca();
                tb_aluno_dados dados = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == data.id_aluno).ToList().Single();

                if (dados.ds_email.Count() > 0)
                {
                    txtEmail.Text = dados.ds_email;
                }
            }
            catch (Exception)
            {
                txtEmail.Clear();
                return;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarEmprestimo();

                MessageBox.Show($"Alteração efetuado com sucesso!", "Biblioteca",
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

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void AlterarEmprestimo()
        {
            tb_emprestimo emprestimo = new tb_emprestimo();
            emprestimo.bt_devolvido = chkDevolvido.Checked;
            emprestimo.nm_funcionario = txtFuncionario.Text;
            emprestimo.dt_devolucao = Convert.ToDateTime(dtpDevolucao.Text);
            emprestimo.tb_livro_id_livro = Convert.ToInt32(cboLivro.SelectedValue);
            emprestimo.dt_emprestimo = Convert.ToDateTime(dtpEmprestimo.Text);

            tb_aluno_dados dados = new tb_aluno_dados();
            dados.ds_email = txtEmail.Text;
            dados.id_aluno_dados = idAluno;

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            emprestimos.AlterarEmprestimo(emprestimo, id, dados);
        }
    }
}
