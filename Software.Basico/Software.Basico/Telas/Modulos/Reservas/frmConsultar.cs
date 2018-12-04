using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Base;

namespace Software.Basico.Telas.Modulos.Reservas
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void CarregarGrid()
        {
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;

            btnAlterar.BackColor = Tema.Segundaria;
            btnCancelar.BackColor = Tema.Segundaria;
            btnNova.BackColor = Tema.Segundaria;

            btnNova.ForeColor = Tema.Texto;
            btnCancelar.ForeColor = Tema.Texto;
            btnAlterar.ForeColor = Tema.Texto;
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            Reservas.frmCadastrar frmCadastrar = new Reservas.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frmCadastrar);
        }
    }
}
