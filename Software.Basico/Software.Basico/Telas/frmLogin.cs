using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            TemaTela();
            Arredondar();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.ShowDialog();
            Show();
        }

        private void Arredondar()
        {
            Gp gp = new Gp();

            btnLogar.Region = new Region(gp.graphicsPath(btnLogar));
            txtLogin.Region = new Region(gp.graphicsPath(txtLogin));
            txtSenha.Region = new Region(gp.graphicsPath(txtSenha));
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;
        }
    }
}
