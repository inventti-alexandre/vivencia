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

namespace Software.Basico.Telas
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            // Inicia contagem para término da Splash Screen
            Task.Factory.StartNew(() =>
            {
                SendEmail();
                // Espera 5 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(2000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmPrincipal frm = new frmPrincipal();
                    Hide();
                    frm.ShowDialog();
                    if (Tema.btnTema == false)
                     this.Close();
                }));
            });
        }

        private void SendEmail()
        {
            try
            {
                DateTime email5dias = DateTime.Today;
                email5dias = email5dias.AddDays(5);

                AzureBiblioteca db = new AzureBiblioteca();
                List<tb_emprestimo> livrodia = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Today && x.bt_devolvido == false && x.tb_notificacao.bt_emailDia == false).ToList();
                List<tb_emprestimo> livroatrasado = db.tb_emprestimo.Where(x => x.dt_devolucao < DateTime.Today && x.bt_devolvido == false && x.tb_notificacao.bt_emailAtrasado == false).ToList();
                List<tb_emprestimo> livro5dia = db.tb_emprestimo.Where(x => x.dt_devolucao == email5dias && x.bt_devolvido == false && x.tb_notificacao.bt_email5DIa == false).ToList();

                if (livrodia.Count != 0 || livroatrasado.Count != 0 || livro5dia.Count != 0)
                {
                    EnviarEmail5Dia();
                    EnviarEmailAtrasado();
                    EnviarEmailDia();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The underlying provider failed on Open"))
                    MessageBox.Show("Não é possivel conectar-se ao servidor. Verifique sua conexão com a internet!\nConsulte the tool Peedroc's", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"Ocorreu um erro não identificado: {ex.Message}", "Biblioteca",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EnviarEmail5Dia()
        {
            DateTime email5dias = DateTime.Today;
            email5dias = email5dias.AddDays(5);

            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> livro5dia = db.tb_emprestimo.Where(x => x.dt_devolucao == email5dias && x.bt_devolvido == false && x.tb_notificacao.bt_email5DIa == false).ToList();


            if (livro5dia.Count != 0)
            {
                foreach (tb_emprestimo emprestimo in livro5dia)
                {
                    if (emprestimo.tb_locatario_id_locatario != null)
                        Send(emprestimo.tb_locatario.ds_email, emprestimo.tb_locatario.nm_locatario);
                    else
                    {
                        tb_aluno_dados emailAluno = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == emprestimo.tb_turma_aluno_id_turma_aluno).ToList().Single();
                        Send(emailAluno.ds_email, emprestimo.tb_turma_aluno.tb_aluno.nm_aluno);
                    }

                    tb_notificacao alt = db.tb_notificacao.Where(x => x.id_notificacao == emprestimo.tb_notificacao_id_notificacao).ToList().Single();
                    alt.bt_email5DIa = true;
                    db.SaveChanges();
                }

                void Send(string email, string nome)
                {
                    EmailDTO mail = new EmailDTO();
                    mail.Assunto = "FALTAM 5 DIAS PARA A DEVOULUÇÃO!";
                    mail.DestinatarioEmail = email;
                    mail.DestinatarioNome = nome;
                    mail.Mensagem = Resources.email2;
                    mail.RemetenteSenha = "pbtadmin1234";
                    mail.RemetenteNome = "Biblioteca FREI";
                    mail.RemetenteEmail = "pb.technology.ltda@gmail.com";

                    EmailSend send = new EmailSend();
                    send.EnviarEmail(mail);
                }
            }
            else
                return;
        }

        private void EnviarEmailDia()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> emprestimos = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Today && x.bt_devolvido == false && x.tb_notificacao.bt_emailDia == false).ToList();


            if (emprestimos.Count != 0)
            {
                foreach (tb_emprestimo emprestimo in emprestimos)
                {
                    if (emprestimo.tb_locatario_id_locatario != null)
                        Send(emprestimo.tb_locatario.ds_email, emprestimo.tb_locatario.nm_locatario);                        
                    else
                    {
                        tb_aluno_dados emailAluno = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == emprestimo.tb_turma_aluno_id_turma_aluno).ToList().Single();
                        Send(emailAluno.ds_email, emprestimo.tb_turma_aluno.tb_aluno.nm_aluno);
                    }
                    
                    tb_notificacao alt = db.tb_notificacao.Where(x => x.id_notificacao == emprestimo.tb_notificacao_id_notificacao).ToList().Single();
                    alt.bt_emailDia = true;
                    db.SaveChanges();
                }

                void Send(string email, string nome)
                {
                    EmailDTO mail = new EmailDTO();
                    mail.Assunto = "HOJE É DIA DE DEVOLUÇÃO!";
                    mail.DestinatarioEmail = email;
                    mail.DestinatarioNome = nome;
                    mail.Mensagem = Resources.htmlEmailDia;
                    mail.RemetenteSenha = "pbtadmin1234";
                    mail.RemetenteNome = "Biblioteca FREI";
                    mail.RemetenteEmail = "pb.technology.ltda@gmail.com";

                    EmailSend send = new EmailSend();
                    send.EnviarEmail(mail);
                }
            }
            else
                return;
        }

        private void EnviarEmailAtrasado()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> livroatrasado = db.tb_emprestimo.Where(x => x.dt_devolucao < DateTime.Today && x.bt_devolvido == false && x.tb_notificacao.bt_emailAtrasado == false).ToList();


            if (livroatrasado.Count != 0)
            {
                foreach (tb_emprestimo emprestimo in livroatrasado)
                {
                    if (emprestimo.tb_locatario_id_locatario != null)
                        Send(emprestimo.tb_locatario.ds_email, emprestimo.tb_locatario.nm_locatario);
                    else
                    {
                        tb_aluno_dados emailAluno = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == emprestimo.tb_turma_aluno_id_turma_aluno).ToList().Single();
                        Send(emailAluno.ds_email, emprestimo.tb_locatario.nm_locatario);
                    }

                    tb_notificacao alt = db.tb_notificacao.Where(x => x.id_notificacao == emprestimo.tb_notificacao_id_notificacao).ToList().Single();
                    alt.bt_emailAtrasado = true;
                    db.SaveChanges();
                }

                void Send(string email, string nome)
                {
                    EmailDTO mail = new EmailDTO();
                    mail.Assunto = "ENTREGA DO LIVRO ATRASADA!";
                    mail.DestinatarioEmail = email;
                    mail.DestinatarioNome = nome;
                    mail.Mensagem = Resources.email3;
                    mail.RemetenteSenha = "pbtadmin1234";
                    mail.RemetenteNome = "Biblioteca FREI";
                    mail.RemetenteEmail = "pb.technology.ltda@gmail.com";

                    EmailSend send = new EmailSend();
                    send.EnviarEmail(mail);
                }
            }
            else
                return;
        }
    }
}
