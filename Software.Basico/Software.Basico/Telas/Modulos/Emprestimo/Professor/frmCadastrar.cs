using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Base;
using Software.Basico.DB.Livros;
using Software.Basico.DB.Locatorio;
using Software.Basico.DB.Emprestimo;
using Blibioteca.Developers.Validacao;

namespace Software.Basico.Telas.Modulos.Emprestimo.Professor
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
            CarregarCombo();
        }

        int id;
        bool cpf;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtFuncionario.Clear();
            txtNome.Clear();
            txtAutor.Clear();
            txtEmail.Clear();
            txtEditora.Clear();
            txtGenero.Clear();
            txtCPF.Clear();
            txtCelular.Clear();
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnCancelar.BackColor = Tema.Segundaria;
            btnAlterar.BackColor = Tema.Segundaria;

            btnCancelar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnAlterar.ForeColor = Tema.Texto;
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

            tb_locatario prof = new tb_locatario();
            prof.nm_locatario = txtNome.Text;
            prof.nu_celular = txtCelular.Text;
            prof.nu_cpf = txtCPF.Text;
            prof.ds_email = txtEmail.Text;

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            cad = emprestimos.CadastroNovoEmprestimo(emprestimo, prof);
        }

        int cad;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cpf)
            {
                Emprestimo();

                if (cad != 0)
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Biblioteca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clean(); 
                }
            }
            else
                MessageBox.Show("Você deve validar o CPF antes!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void PreencherCampos(int idEmprestimo)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_emprestimo emprestimo = db.tb_emprestimo.Where(x => x.id_emprestimo == idEmprestimo).ToList().Single();

            cboLivro.SelectedItem = emprestimo.tb_livro_id_livro;
            txtCelular.Text = emprestimo.tb_locatario.nu_celular;
            txtCPF.Text = emprestimo.tb_locatario.nu_cpf;
            txtEmail.Text = emprestimo.tb_locatario.ds_email;
            txtFuncionario.Text = emprestimo.nm_funcionario;
            txtNome.Text = emprestimo.tb_locatario.nm_locatario;
            id = emprestimo.id_emprestimo;
            chkDevolvido.Checked = emprestimo.bt_devolvido;
            dtpEmprestimo.Value = emprestimo.dt_emprestimo;
            dtpDevolucao.Value = emprestimo.dt_devolucao;

            dtpDevolucao.Enabled = false;
            dtpEmprestimo.Enabled = false;
            dtpEmprestimo.Visible = true;
            label13.Visible = true;
            chkDevolvido.Visible = true;
            label12.Visible = true;
            btnAlterar.Visible = true;
        }

        private void TravaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                CPF val = new CPF();
                cpf = val.ValidarCPF(txtCPF.Text);

                AzureBiblioteca db = new AzureBiblioteca();
                tb_locatario locatario = db.tb_locatario.Where(x => x.nu_cpf == txtCPF.Text).ToList().Single();

                if (locatario.nm_locatario != null)
                {
                    txtNome.Text = locatario.nm_locatario;
                    txtEmail.Text = locatario.ds_email;
                    txtCelular.Text = locatario.nu_celular;
                }  
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("A sequência não contém elementos"))
                    MessageBox.Show($"CPF ainda não cadastrado", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLivro_TextChanged(object sender, EventArgs e)
        {
            tb_livro book = cboLivro.SelectedItem as tb_livro;
            
            txtAutor.Text = book.tb_autor.nm_autor;
            txtGenero.Text = book.tb_genero.nm_genero;
            txtEditora.Text = book.nm_editora;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarEmprestimo();

            MessageBox.Show("Emprestimo alterado com sucesso!", "Biblioteca", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void AlterarEmprestimo()
        {
            tb_emprestimo emprestimo = new tb_emprestimo();
            emprestimo.bt_devolvido = chkDevolvido.Checked;
            emprestimo.nm_funcionario = txtFuncionario.Text;
            emprestimo.dt_devolucao = Convert.ToDateTime(dtpDevolucao.Text);
            emprestimo.tb_livro_id_livro = Convert.ToInt32(cboLivro.SelectedValue);
            emprestimo.dt_emprestimo = Convert.ToDateTime(dtpEmprestimo.Text);

            tb_locatario prof = new tb_locatario();
            prof.nm_locatario = txtNome.Text;
            prof.nu_celular = txtCelular.Text;
            prof.nu_cpf = txtCPF.Text;
            prof.ds_email = txtEmail.Text;

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            emprestimos.AlterarEmprestimo(emprestimo, id, prof);
        }

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
               AlterarEmprestimo();

        }
    }     
 }

