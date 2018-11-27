using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Usuarios
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void TemaTela()
        {
            //Mudar cor dos Panel.
            panel1.BackColor = Tema.Primaria;

            //Mudar cor dos botões.
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnListar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
            btnListar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();

            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
