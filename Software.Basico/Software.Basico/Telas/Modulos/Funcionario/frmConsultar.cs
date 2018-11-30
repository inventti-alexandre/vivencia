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
using System.Data.Entity;
using Software.Basico.DB.Funcionario;

namespace Software.Basico.Telas.Modulos.Funcionario
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
            //Mudar cor dos Panel.
            panel1.BackColor = Tema.Primaria;

            //Mudar cor dos botões.
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnListar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
        }

        private void CarregarGrid()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<tb_Funcionario> funcList = business.ListarFuncionarios();

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = funcList;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
        }

        private void RemoverFuncionario()
        {
            try
            {
                tb_Funcionario funcionario = dgvUsuarios.CurrentRow.DataBoundItem as tb_Funcionario;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.RemoverFuncionario(funcionario.id_funcionario);

                MessageBox.Show("Funcionário Removido com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarGrid();
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tb_Funcionario funcionario = dgvUsuarios.CurrentRow.DataBoundItem as tb_Funcionario;

            frmCadastrar frm = new frmCadastrar();
            frm.PreencherCampos(funcionario.id_funcionario);
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
