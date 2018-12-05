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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFuncionario.Clear();
            txtNome.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtEmail.Clear();
            txtGenero.Clear();
            txtCPF.Clear();
            txtCelular.Clear();
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

            tb_locatario prof = new tb_locatario();
            prof.nm_locatario = txtNome.Text;
            prof.nu_celular = txtCelular.Text;
            prof.nu_cpf = txtCPF.Text;

            EmprestimoBusiness emprestimos = new EmprestimoBusiness();
            emprestimos.CadastroNovoEmprestimo(emprestimo, prof);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Emprestimo();

            MessageBox.Show("Cadastro efetuado com sucesso!", "Biblioteca",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }     
 }

