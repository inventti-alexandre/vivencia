using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Autor;
using Software.Basico.DB.Base;

namespace Software.Basico.Telas.Modulos.Autor
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
            CarregarGrid();
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
            frmCadastroAutor frm = new frmCadastroAutor();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            string autor = txtNome.Text.Trim();
            string nacionalidade = txtNacionalidade.Text.Trim();

            AutorBusiness business = new AutorBusiness();
            //List<tb_autor> aut = business.ListarAutores();
            List<tb_autor> vem = business.ListarAutores(autor, nacionalidade);

            dgvAutor.AutoGenerateColumns = false;
            dgvAutor.DataSource = vem;      
          
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_autor autor = dgvAutor.CurrentRow.DataBoundItem as tb_autor;

                frmCadastroAutor frm = new frmCadastroAutor();
                frm.PreencherCampos(autor.id_autor);
                ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
            }
            catch (Exception)
            {
                MessageBox.Show($"Você deve selecionar um livro para visualizar!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                tb_autor Autor = dgvAutor.CurrentRow.DataBoundItem as tb_autor;

                AutorBusiness business = new AutorBusiness();
                business.RemoverAutor(Autor.id_autor);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("An error occurred while updating the entries. See the inner exception for details."))
                    MessageBox.Show($"Este autor está ligado a um livro,\ne por isso não pode ser apagado!", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Você deve selecionar um autor para remover!", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_autor autor = dgvAutor.CurrentRow.DataBoundItem as tb_autor;

            AzureBiblioteca db = new AzureBiblioteca();
            tb_autor func = db.tb_autor.Where(x => x.id_autor == autor.id_autor).ToList().Single();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CarregarGrid();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CarregarGrid();
        }
    }
}
