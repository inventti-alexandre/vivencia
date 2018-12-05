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

            dgvgenero.AutoGenerateColumns = false;
            dgvgenero.DataSource = nha.ListarGeneros();


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
            try
            {
                tb_genero genero = dgvgenero.CurrentRow.DataBoundItem as tb_genero;

                GeneroBusiness business = new GeneroBusiness();
                business.RemoverGenero(genero.id_genero);
                CarregarGrid();
            }
            catch (Exception)
            {
                MessageBox.Show($"Você deve selecionar um genero para remover!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_genero genero = dgvgenero.CurrentRow.DataBoundItem as tb_genero;

            AzureBiblioteca db = new AzureBiblioteca();
            tb_genero func = db.tb_genero.Where(x => x.id_genero == genero.id_genero).ToList().Single();
        }
    }
}
