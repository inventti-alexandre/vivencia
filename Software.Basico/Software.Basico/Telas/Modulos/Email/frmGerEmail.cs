using Software.Basico.APIs.Email;
using Software.Basico.DB.Base;
using Software.Basico.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Email
{
    public partial class frmGerEmail : Form
    {
        public frmGerEmail()
        {
            InitializeComponent();
            CarregarDias();
            TemaTela();
        }

        private void CarregarDias()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> livrosDia = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Today).ToList();
            //List<tb_emprestimo> livro5dia = db.tb_emprestimo.Where(x => ((TimeSpan)(x.dt_devolucao - DateTime.Today)).Days < 5).ToList();
            //List<tb_emprestimo> livroatrasado = db.tb_emprestimo.Where(x => ((TimeSpan)(x.dt_devolucao - DateTime.Today)).Days < 0).ToList();

            lblQntLivrosDia.Text = livrosDia.Count.ToString();
            //lblLivro5Dias.Text = livro5dia.Count.ToString();
            //lblLivroAtrasado.Text = livroatrasado.Count.ToString();

            if (livrosDia.Count > 0)
                btnEnviarDia.Enabled = true;
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;
            btnEnviar5Dia.BackColor = Tema.Segundaria;
            btnEnviarAtrasado.BackColor = Tema.Segundaria;
            btnEnviarDia.BackColor = Tema.Segundaria;

            btnEnviar5Dia.ForeColor = Tema.Texto;
            btnEnviarAtrasado.ForeColor = Tema.Texto;
            btnEnviarDia.ForeColor = Tema.Texto;
        }

        private void btnEmailDia_Click(object sender, EventArgs e)
        {
            try
            {
                EnviarEmailDia();

                MessageBox.Show("Emails enviados com sucesso!", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnEnviarDia.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EnviarEmail5Dia()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> livro5dia = db.tb_emprestimo.Where(x => ((TimeSpan)(x.dt_devolucao - DateTime.Today)).Days < 5).ToList();

            var emails = livro5dia.Select(x => x.ds_email);

            if (livro5dia.Count != 0)
            {
                Send(emails);

                void Send(IEnumerable<string> Destinatarios)
                {
                    foreach (string destino in Destinatarios)
                    {
                        EmailDTO email = new EmailDTO();
                        email.Assunto = "Dia de Devolução!";
                        email.DestinatarioEmail = destino;
                        email.DestinatarioNome = "";
                        email.Mensagem = Resources.htmlEmail;
                        email.RemetenteSenha = "pbtadmin1234";
                        email.RemetenteNome = "Biblioteca FREI";
                        email.RemetenteEmail = "pb.technology.ltda@gmail.com";

                        EmailSend send = new EmailSend();
                        send.EnviarEmail(email);
                    }
                }
            }
            else
                throw new ArgumentException("Nenhum email a ser enviado!");
        }

        private void EnviarEmailDia()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> emprestimos = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Today).ToList();
            var emails = emprestimos.Select(x => x.ds_email);

            if (emprestimos.Count != 0)
            {
                Send(emails);

                void Send(IEnumerable<string> Destinatarios)
                {
                    foreach (string destino in Destinatarios)
                    {
                        EmailDTO email = new EmailDTO();
                        email.Assunto = "Dia de Devolução!";
                        email.DestinatarioEmail = destino;
                        email.DestinatarioNome = "";
                        email.Mensagem = Resources.htmlEmail;
                        email.RemetenteSenha = "pbtadmin1234";
                        email.RemetenteNome = "Biblioteca FREI";
                        email.RemetenteEmail = "pb.technology.ltda@gmail.com";

                        EmailSend send = new EmailSend();
                        send.EnviarEmail(email);
                    }
                }
            }
            else
                throw new ArgumentException("Nenhum email a ser enviado!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEnviarDia.Enabled == true || btnEnviar5Dia.Enabled == true || btnEnviarAtrasado.Enabled == true)
                    throw new ArgumentException("Ainda essiste lembretes a serem enviados,\nQuer mesmo fechar a janela?");
                else
                {
                    Program.notificacaoEmail = false;
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                if (MessageBox.Show(ex.Message, "Biblioteca",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                    return;
            }
        }
    }
}
