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
                System.Threading.Thread.Sleep(5000);

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
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> emprestimos = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Now).ToList();
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
                return;            
        }
    }
}
