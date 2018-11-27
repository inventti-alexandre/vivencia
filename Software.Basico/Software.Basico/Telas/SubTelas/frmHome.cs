using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.APIs.Email;

namespace Software.Basico.Telas.SubTelas
{
    public partial class frmHome : UserControl
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            EnviarEmail();
            MessageBox.Show("Email enviado com sucesso!");
        }

        private void EnviarEmail()
        {
            EmailDTO dto = new EmailDTO();
            dto.Assunto = "Teste";
            dto.DestinatarioEmail = "phm1080@gmail.com";
            dto.DestinatarioNome = "Pedro";
            dto.RemetenteEmail = "pb.technology.ltda@gmail.com";
            dto.RemetenteNome = "Program Boys";
            dto.RemetenteSenha = "pbtadmin1234";

            EmailSend send = new EmailSend();
            send.EnviarEmail(dto);
        }
    }
}
