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
using Software.Basico.DB.Estoque;
using Software.Basico.DB.Livros;

namespace Software.Basico.Telas.Modulos.Estoque
{
    public partial class EstoqueCadastrar : UserControl
    {
        public EstoqueCadastrar()
        {
            InitializeComponent();
           
        }
        private void CarregarCombos()
        {
            LivroBusiness asbusiness = new LivroBusiness();
            List<tb_livro> livros = asbusiness.ListarLivros();

            cboxlivro.ValueMember = nameof(tb_livro.ds_titulo);
            cboxlivro.SelectedItem = nameof(tb_livro.id_livro);
            cboxlivro.DataSource = asbusiness;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarNoEstoque();
        }
        private void CadastrarNoEstoque()
        {

            try
            {
                tb_estoque reserva = new tb_estoque();

                reserva.qtd_livro = Convert.ToInt32(numericUpDown1.Text.Trim());

                EstoqueBusiness business = new EstoqueBusiness();
                business.CadastrarnoEstoque(reserva);

                MessageBox.Show("Produto Cadastrado com sucesso", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericUpDown1.Text.DefaultIfEmpty();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro nhao identificado: {ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstoqueCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
