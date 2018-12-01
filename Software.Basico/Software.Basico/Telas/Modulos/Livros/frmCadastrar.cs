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

namespace Software.Basico.Telas.Modulos.Livros
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarLivro();
        }

        private void CadastrarLivro()
        {
            try
            {
                tb_livro livro = new tb_livro();

                livro.autor_id_autor = Convert.ToInt32(cboAutor.ValueMember);
                livro.ds_condicoes = cboCondicao.SelectedItem.ToString();
                livro.ds_idioma = txtIdioma.Text;
                livro.ds_palavrasChaves = txtPalavrasChaves.Text;
                livro.ds_subtitulo = txtSubtitulo.Text;
                livro.ds_tipo = txtTipo.Text;
                livro.ds_titulo = txtTitulo.Text;
                //adicionar imagem do livro
                livro.nm_editora = txtEditora.Text;
                livro.nu_isbn = txtISBN.Text;
                livro.nu_volume = Convert.ToInt32(txtVolume.Text);

                LivroBusiness business = new LivroBusiness();
                business.CadastrarLivro(livro);

                MessageBox.Show("Livro cadastrado com sucesso!", "Biblioteca",
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
    }
}
