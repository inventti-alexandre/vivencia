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
using Software.Basico.DB.Reserva;

namespace Software.Basico.Telas.Modulos.Reservas
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            TemaTela();
            CarregarGridLocatario();
            CarregarGridAluno();
        }

        private void CarregarGridLocatario()
        { 
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvReserva.AutoGenerateColumns = false;
            dgvReserva.DataSource = reservaBusiness.ListaReservadoLocatario();

          
        }

        private void CarregarGridLocatarioParaConsulta()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvReserva.AutoGenerateColumns = false;
            dgvReserva.DataSource = reservaBusiness.ConsultarReservadoLocatarioPorNome(txtlocatario.Text);
        }

        private void CarregarGridAluno()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvaluno.AutoGenerateColumns = false;
            dgvaluno.DataSource = reservaBusiness.ListaReservadoAluno();
        }

        private void CarregarGridAlunoParaConsulta()
        {
            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvaluno.AutoGenerateColumns = false;
            dgvaluno.DataSource = reservaBusiness.ConsultarReservadoLocatarioPorNomeAluno(txtfiltraraluno.Text);
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
            
        }

        private void btnNova_Click_1(object sender, EventArgs e)
        {
            Reservas.frmCadastrar frmCadastrar = new Reservas.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frmCadastrar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bntconsultar_Click(object sender, EventArgs e)
        {
            CarregarGridLocatarioParaConsulta();
        }

        private void btnfiltaraluno_Click(object sender, EventArgs e)
        {
            CarregarGridAlunoParaConsulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservas.frmCadastrar frmCadastrar = new Reservas.frmCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frmCadastrar);
        }
    }
}
