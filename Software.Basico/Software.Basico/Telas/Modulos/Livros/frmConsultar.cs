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
using Software.Basico.DB.Autor;

namespace Software.Basico.Telas.Modulos.Livros
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
            pnTop.BackColor = Tema.Primaria;
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;

            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
            btnListar.ForeColor = Tema.Texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            string titulo = txtTitulo.Text.Trim();
            string palavra = txtPalavraChave.Text.Trim();
            string autor = txtAutor.Text.Trim();

            LivroBusiness business = new LivroBusiness();
            List<vw_Livro_Autor_Genero> livros = business.ListarViewLivros(titulo, autor, palavra);

            dgvLivros.AutoGenerateColumns = false;
            dgvLivros.DataSource = livros;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                vw_Livro_Autor_Genero livro = dgvLivros.CurrentRow.DataBoundItem as vw_Livro_Autor_Genero;

                frmCadastrar frm = new frmCadastrar();
                frm.PreencherCampos(livro.id_livro);
                ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Você deve selecionar um livro para visualizar!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                vw_Livro_Autor_Genero livro = dgvLivros.CurrentRow.DataBoundItem as vw_Livro_Autor_Genero;

                LivroBusiness business = new LivroBusiness();
                business.RemoverLivro(livro.id_livro);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Você deve selecionar um livro para remover!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
