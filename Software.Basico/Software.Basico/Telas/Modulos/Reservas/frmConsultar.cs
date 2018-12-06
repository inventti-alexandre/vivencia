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
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            //List<vw_reserva> reservas = db.vw_reserva.ToList();

            ReservaBusiness reservaBusiness = new ReservaBusiness();
            dgvReserva.AutoGenerateColumns = false;
            //dgvReserva.DataSource = reservaBusiness.ConsultarReservas();

            List<tb_reserva> dto = new List<tb_reserva>();
            dto = db.tb_reserva.ToList();
            dgvteste.AutoGenerateColumns = false;
            dgvteste.DataSource = dto;
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
