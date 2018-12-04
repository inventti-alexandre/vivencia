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
            DateTime email5dias = DateTime.Today;
            email5dias = email5dias.AddDays(5);

            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_emprestimo> livrodia = db.tb_emprestimo.Where(x => x.dt_devolucao == DateTime.Today).ToList();
            List<tb_emprestimo> livroatrasado = db.tb_emprestimo.Where(x => x.dt_devolucao < DateTime.Today).ToList();
            List<tb_emprestimo> livro5dia = db.tb_emprestimo.Where(x => x.dt_devolucao == email5dias).ToList();

            if (livrodia.Count != 0 || livroatrasado.Count != 0 || livro5dia.Count != 0)
                Program.notificacaoEmail = true;
            else
                return;
        }
    }
}
