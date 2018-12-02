using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Software.Basico.DB.Base;
using Software.Basico.DB.Livros;
using Software.Basico.DB.Autor;
using Software.Basico.DB.Genero;

namespace Software.Basico.Telas.Modulos.Livros
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
            CarregarCombos();
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;
          
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
        }

        private void CarregarCombos()
        {
            AutorBusiness abusiness = new AutorBusiness();
            List<tb_autor> autores = abusiness.ListarAutores();

            cboAutor.ValueMember = nameof(tb_autor.id_autor);
            cboAutor.DisplayMember = nameof(tb_autor.nm_autor);
            cboAutor.DataSource = autores;

            GeneroBusiness gbusiness = new GeneroBusiness();
            List<tb_genero> generos = gbusiness.ListarGeneros();

            cboGenero.ValueMember = nameof(tb_genero.id_genero);
            cboGenero.DisplayMember = nameof(tb_genero.nm_genero);
            cboGenero.DataSource = generos;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarLivro();
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void AlterarLivro()
        {
            try
            {
                tb_livro livro = new tb_livro();

                livro.id_livro = Convert.ToInt32(lblid.Text);
                livro.autor_id_autor = Convert.ToInt32(cboAutor.ValueMember);
                livro.ds_condicoes = cboCondicao.SelectedItem.ToString();
                livro.ds_idioma = txtIdioma.Text;
                livro.ds_palavrasChaves = txtPalavrasChaves.Text;
                livro.ds_subtitulo = txtSubtitulo.Text;
                livro.ds_tipo = cboTipo.SelectedItem.ToString();
                livro.ds_titulo = txtTitulo.Text;
                livro.img_Capa = ImagemPlugin.ConverterParaString(imgLivro.Image);
                livro.nm_editora = txtEditora.Text;
                livro.nu_isbn = txtISBN.Text;
                livro.nu_volume = Convert.ToInt32(txtVolume.Text);

                LivroBusiness business = new LivroBusiness();
                business.AlterarLivro(livro, livro.id_livro);

                MessageBox.Show("Livro alterado com sucesso!", "Biblioteca",
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

        public void PreencherCampos(int idLivro)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_livro livro = db.tb_livro.Where(x => x.id_livro == idLivro).ToList().Single();

            txtIdioma.Text = livro.ds_idioma;
            txtPalavrasChaves.Text = livro.ds_palavrasChaves;
            txtSubtitulo.Text = livro.ds_subtitulo;
            txtTitulo.Text = livro.ds_titulo;
            imgLivro.Image = ImagemPlugin.ConverterParaImagem(livro.img_Capa);
            txtEditora.Text = livro.nm_editora;
            txtISBN.Text = livro.nu_isbn;
            txtVolume.Text = livro.nu_volume.ToString();
            lblid.Text = livro.id_livro.ToString();

            btnCadastrar.Visible = false;
            lblid.Visible = true;
            lblidTxt.Visible = true;
        }

        private void CadastrarLivro()
        {
            try
            {
                tb_livro livro = new tb_livro();

                livro.autor_id_autor = Convert.ToInt32(cboAutor.SelectedValue);
                livro.tb_genero_id_genero = Convert.ToInt32(cboGenero.SelectedValue);
                livro.ds_condicoes = cboCondicao.SelectedItem.ToString();
                livro.ds_idioma = txtIdioma.Text;
                livro.ds_palavrasChaves = txtPalavrasChaves.Text;
                livro.ds_subtitulo = txtSubtitulo.Text;
                livro.ds_tipo = cboTipo.SelectedItem.ToString();
                livro.ds_titulo = txtTitulo.Text;
                livro.img_Capa = ImagemPlugin.ConverterParaString(imgLivro.Image);
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

        private void CarregarImagem()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                imgLivro.ImageLocation = dialog.FileName;
            }
        }

        private void btnAddAutor_Click(object sender, EventArgs e)
        {
            Autor.frmCadastroAutor frm = new Autor.frmCadastroAutor();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            Genero.frmCadastrar frm = new Genero.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarLivro();
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }
    }
}
