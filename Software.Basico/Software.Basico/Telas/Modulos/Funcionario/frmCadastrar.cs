using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB;
using Software.Basico.DB.Funcionario;

namespace Software.Basico.Telas.Modulos.Funcionario
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void TemaTela()
        {
            //Mudar cor dos Panel.
            panel1.BackColor = Tema.Primaria;

            //Mudar cor dos Botões.
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FecharJanela();
        }

        private void FecharJanela()
        {
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario();
            FecharJanela();
        }

        private void CadastrarFuncionario()
        {
            try
            {
                tb_Funcionario dto = new tb_Funcionario();
                dto.nm_funcionario = txtNome.Text;
                dto.nu_cpf = txtCPF.Text;
                dto.nu_senha = txtSenha.Text;
                dto.ds_sexo = txtSexo.Text;
                dto.ds_email = txtEmail.Text;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.CadastrarFuncionario(dto);

                MessageBox.Show("Funcionário Cadastrado com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFuncionario();
            FecharJanela();
        }

        private void AlterarFuncionario()
        {
            try
            {
                BibliotecaDBAzure db = new BibliotecaDBAzure();
                int idFuncionario = Convert.ToInt32(lblId.Text);

                tb_Funcionario dto = db.tb_Funcionario.Where(x => x.id_funcionario == idFuncionario).ToList().Single();
                dto.nm_funcionario = txtNome.Text;
                dto.nu_cpf = txtCPF.Text;
                dto.nu_senha = txtSenha.Text;
                dto.ds_sexo = txtSexo.Text;
                dto.ds_email = txtEmail.Text;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.AlterarFuncionario(dto, idFuncionario);

                MessageBox.Show("Funcionário Alterado com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencherCampos(int idFuncionario)
        {
            BibliotecaDBAzure db = new BibliotecaDBAzure();

            tb_Funcionario funcionario = db.tb_Funcionario.Where(x => x.id_funcionario == idFuncionario).ToList().Single();

            txtNome.Text = funcionario.nm_funcionario;
            txtCPF.Text = funcionario.nu_cpf;
            txtEmail.Text = funcionario.ds_email;
            txtSenha.Text = funcionario.nu_senha;
            txtSexo.Text = funcionario.ds_sexo;
            lblId.Text = funcionario.id_funcionario.ToString();
        }
    }
}
