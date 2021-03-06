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
using Software.Basico.DB.Genero;

namespace Software.Basico.Telas.Modulos.Genero
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
            CarregarGrid();

        }
        public void CarregarGrid()
        {
            GeneroBusiness nha = new GeneroBusiness();

            dgvLivros.AutoGenerateColumns = false;
            dgvLivros.DataSource = nha.ListarGeneros();


        }

        private void Tematela()
        {
            btnCadastrar.BackColor = Tema.Segundaria;

            pnTop.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;

            btnCadastrar.ForeColor = Tema.Texto;


        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
           
            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarGenero();
        }

        private void CadastrarGenero()
        {
            try
            {
                tb_genero genero = new tb_genero();

                genero.nm_genero = txtGenero.Text.Trim();


                GeneroBusiness business = new GeneroBusiness();
                business.CadastrarGenero(genero);

                MessageBox.Show("Genero do livro cadastrado com sucesso!", "Biblioteca",
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
                MessageBox.Show($"Ocorreu um erro nhao identificado: {ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCadastroDeGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Livros.frmCadastrar frm = new Livros.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Livros.frmCadastrar frm = new Livros.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);

        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                tb_genero generos = dgvLivros.CurrentRow.DataBoundItem as tb_genero;

                GeneroBusiness business = new GeneroBusiness();
                business.RemoverGenero(generos.id_genero);

                MessageBox.Show("Gênero removido com sucesso!", "Biblioteca", 
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
                if (ex.HResult == -2146233087)
                     MessageBox.Show($"Impossivel remover um gênero que está em uso!", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Ocorreu um erro nhao identificado: {ex.Message}", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (e.KeyChar == 13)
               CadastrarGenero();
               

        }
    }
}
