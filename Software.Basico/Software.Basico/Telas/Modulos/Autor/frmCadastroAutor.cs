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
using Software.Basico.DB.Autor;

namespace Software.Basico.Telas.Modulos.Autor
{
    public partial class frmCadastroAutor : UserControl
    {
        public frmCadastroAutor()
        {
            InitializeComponent();
        }
        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            //btnRemover.BackColor = Tema.Segundaria;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAutor();
        }
        private void CadastrarAutor()
        {
            try
            {
                tb_autor Autor = new tb_autor();
               
                Autor.nm_autor = txtAutor.Text.Trim();
                Autor.nm_nomeCompleto = txtNomeCompleto.Text.Trim();
                Autor.ds_nacionalidade = txtNascionalidade.Text.Trim();

                if (Autor.nm_autor == string.Empty)
                {
                    MessageBox.Show("Diga quem é o Autor.");
                    return;
                }

                AutorBusiness business = new AutorBusiness();
                business.CadastrarAutor(Autor);

                MessageBox.Show("Autor cadastrado com sucesso!", "Biblioteca",
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
            txtNomeCompleto.Clear();
            txtNascionalidade.Clear();
        }

        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtNascionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void frmCadastroAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
