using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Reservas
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;

            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             // Oi gente, vocês não acham melhor que 
            //a data da reserva fique somente no código? 
           //  pq a data da reserva vai ser sempre o dia atual, ou seja, é só dar um datetime.now 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Reservas.frmConsultar frm = new Reservas.frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
