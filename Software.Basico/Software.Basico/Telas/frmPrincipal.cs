using Blibioteca.Developers.APIs.Clima;
using Software.Basico.Telas.Modulos.Email;
using Software.Basico.Telas.SubTelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Software.Basico.Telas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            TemaTela();
            ScreenFrmHome();
            Clima();
            Sininho();
        }

        private void Sininho()
        {
            if (Program.notificacaoEmail == true)
                btnSininho.Visible = true;
        }

        public void CarregarPanel(System.Windows.Forms.UserControl frm)
        {
            if (pnPrincipal.Controls.Count == 1)
                pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(frm);
        }

        private void Clima()
        {
            ClimaModel clima = new ClimaModel();
            TempoResponse tempo = clima.AdivisorTempo("São Paulo");

            if (tempo == null)
                return;

            Umidade.Text = $"Umidade: {tempo.data.humidity}";
            Temperatura.Text = $"{tempo.data.temperature} Cº";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ScreenFrmHome();

            telaSel = 1;

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnHome.Location.Y);
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            frmTema frm = new frmTema();
            CarregarPanel(frm);

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnTemas.Location.Y);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {

            Modulos.Livros.frmConsultar frm = new Modulos.Livros.frmConsultar();
            CarregarPanel(frm);

            telaSel = 3;

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnLivros.Location.Y);
        }
        
        private void btnAutores_Click(object sender, EventArgs e)
        {
            Modulos.Autor.frmConsultar frm = new Modulos.Autor.frmConsultar();
            CarregarPanel(frm);

            telaSel = 4;

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnAutores.Location.Y);
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            Modulos.Emprestimo.frmMenu frm = new Modulos.Emprestimo.frmMenu();
            CarregarPanel(frm);

            telaSel = 5;

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnEmprestimo.Location.Y);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Modulos.Reservas.frmConsultar frm = new Modulos.Reservas.frmConsultar();
            CarregarPanel(frm);

            telaSel = 6;

            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnReservas.Location.Y);
        }

        /// <summary>
        /// Este método é separado do botão pois o Form também utiliza ele.
        /// </summary>
        private void ScreenFrmHome()
        {
            frmHome frm = new frmHome();
            CarregarPanel(frm);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        public void Fechar()
        {
            //Evento ocorrido após clicar em fechar tela.
            Tema.btnTema = false;
            this.Close();
        }

        public void TrocarTema()
        {
            Tema.btnTema = true;
            this.Close();

            frmPrincipal frm = new frmPrincipal();
            frm.Show();
        }

        private void TemaTela()
        {
            string corTema = Tema.tema;

            Tema cor = new Tema();
            if (corTema == "0" || corTema == null)
                cor.CarregarTema0();
            else if (corTema == "1")
                cor.CarregarTema1();
            else if (corTema == "2")
                cor.CarregarTema2();

            //Muda posição da logo dependendo do tema.
            if (Tema.tema == "1")
            {
                panel2.Visible = true;
                logo1.Visible = true;
            }
            else
                logo2.Visible = true;

            //Cores dos Panels segundo o tema
            //this.BackColor = Tema.Principal;
            panel1.BackColor = Tema.Primaria;
            panel3.BackColor = Tema.Primaria;
            panel2.BackColor = Tema.Segundaria;
            pnBtnSel.BackColor = Tema.Segundaria;
            flowLayoutPanel1.BackColor = Tema.Segundaria;
            
            //Cores dos textos segundo o tema
            btnHome.ForeColor = Tema.Texto;
            btnTemas.ForeColor = Tema.Texto;
            btnLivros.ForeColor = Tema.Texto;
            btnAutores.ForeColor = Tema.Texto;
            Question.ForeColor = Tema.Texto;
        }

        private void btnRecursos_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnTemas.Location.Y);
        }

        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnHome.Location.Y);
        }

        private void btnOpcoes_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnLivros.Location.Y);
        }

        private void btnUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnAutores.Location.Y);
        }

        private void btnEmprestimo_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnEmprestimo.Location.Y);
        }

        private void btnReservas_MouseMove(object sender, MouseEventArgs e)
        {
            //Mudar posição do Panel esquerdo
            pnBtnSel.Location = new Point(0, btnReservas.Location.Y);
        }

        private void Question_Click(object sender, EventArgs e)
        {
            //Botão "?"
            frmSobreNos frm = new frmSobreNos();

            if (pnPrincipal.Controls.Count == 1)
                pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(frm);
        }

        //Váriavel de botão do menu que foi clicado por último.
        int telaSel = 1;

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            //Volta do panel para o lado do botão que está atualmente ativo.
            if (telaSel == 1)
                pnBtnSel.Location = new Point(0, btnHome.Location.Y);
            else if (telaSel == 2)
                pnBtnSel.Location = new Point(0, btnTemas.Location.Y);
            else if (telaSel == 3)
                pnBtnSel.Location = new Point(0, btnLivros.Location.Y);
            else if (telaSel == 4)
                pnBtnSel.Location = new Point(0, btnAutores.Location.Y);
            else if (telaSel == 5)
                pnBtnSel.Location = new Point(0, btnEmprestimo.Location.Y);
            else if (telaSel == 6)
                pnBtnSel.Location = new Point(0, btnReservas.Location.Y);
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            //Abre o navegador padrão com o site do instituto.
            System.Diagnostics.Process.Start("http://acaonsfatima.org.br/");
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            //Abre o navegador padrão com o facebook do instituto.
            System.Diagnostics.Process.Start("https://www.facebook.com/Instituto-Social-Nossa-Senhora-de-F%C3%A1tima-230903353703049/");
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            //Horário atual.
            lblHorario.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSininho_Click(object sender, EventArgs e)
        {
            frmGerEmail frm = new frmGerEmail();
            this.Hide();
            frm.ShowDialog();
            Show();

            if (Program.notificacaoEmail == false)
                btnSininho.Visible = false;
        }
    }
}
