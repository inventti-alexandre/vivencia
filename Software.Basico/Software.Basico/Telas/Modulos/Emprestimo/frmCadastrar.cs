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
using Software.Basico.DB.Emprestimo;

namespace Software.Basico.Telas.Modulos.Emprestimo
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
            panel1.BackColor = Tema.Primaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar()
        {
            try
            {
                tb_emprestimo emprestimo = new tb_emprestimo();
                emprestimo.tb_livro_id_livro = Convert.ToInt32(cboLivro.SelectedValue);
                emprestimo.tb_turma_aluno_id_turma_aluno = Convert.ToInt32(cboCurso.SelectedValue);
                

                EmprestimoBusiness business = new EmprestimoBusiness();
                business.CadastroNovoEmprestimo(emprestimo);

                MessageBox.Show("Emprestimo feito com sucesso!", "Biblioteca",
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
