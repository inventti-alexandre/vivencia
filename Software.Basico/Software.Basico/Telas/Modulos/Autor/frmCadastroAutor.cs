﻿using System;
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
            TemaTela();
        }
        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnAlterar.BackColor = Tema.Segundaria;

            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
            btnAlterar.ForeColor = Tema.Texto;
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

                AutorBusiness business = new AutorBusiness();
                business.CadastrarAutor(Autor);

                MessageBox.Show("Autor cadastrado com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAutor.Clear();
                txtNomeCompleto.Clear();
                txtNascionalidade.Clear();
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
            txtNascionalidade.Clear();
            txtNomeCompleto.Clear();
        }

        public void PreencherCampos(int idAutor)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_autor autor = db.tb_autor.Where(x => x.id_autor == idAutor).ToList().Single();

            lblid.Text = autor.id_autor.ToString();
            txtAutor.Text = autor.nm_autor;
            txtNomeCompleto.Text = autor.nm_nomeCompleto;
            txtNascionalidade.Text = autor.ds_nacionalidade;  

            btnCadastrar.Visible = false;
            lblid.Visible = true;
            lblidTxt.Visible = true;
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
            if(e.KeyChar == 13)
                CadastrarAutor();
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
            if (e.KeyChar == 13)
                CadastrarAutor();
                

        }

        private void frmCadastroAutor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                tb_autor autor = new tb_autor();

                autor.id_autor = Convert.ToInt32(lblid.Text);
                autor.nm_autor = txtAutor.Text.Trim();
                autor.nm_nomeCompleto = txtNomeCompleto.Text.Trim();
                autor.ds_nacionalidade = txtNascionalidade.Text.Trim();

                AutorBusiness business = new AutorBusiness();
                business.AlterarAutor(autor, autor.id_autor);

                MessageBox.Show("Autor alterado com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmConsultar frm = new frmConsultar();
                ((frmPrincipal)this.ParentForm).CarregarPanel(frm);

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

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}