using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB.Locatorio;
using Software.Basico.DB.Base;

namespace Software.Basico.Telas.Modulos.Reservas
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
            TemaTela();
            rdnlocatorio.Checked = true;
            CarregarCombo();
        }
        int idlocatorio;
        int idaluno;
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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtaluno_MouseClick(object sender, MouseEventArgs e)
        {
            txtaluno.Text = string.Empty;
        }

        private void ConsultarLocatario()
        {
            if(mktCPF.Text !="   .   .   -")
            { 
            LocatorioBusiness locatorio = new LocatorioBusiness();
            tb_locatario dto = locatorio.ListarPOrCPFLocatario(mktCPF.Text);
            lblLocatario.Text = dto.nm_locatario;
            idlocatorio = dto.id_locatario;
            }
        }

        private void ConsultarAluno()
        {
            if(txtaluno!=null)
            { 
            AzureBiblioteca db = new AzureBiblioteca();
            tb_turma_aluno aluno = db.tb_turma_aluno.Where(x => x.cd_ra == txtaluno.Text).ToList().Single();
            lblAluno.Text = aluno.tb_aluno.nm_aluno;
            }
        }
        private void CarregarCombo()
        {
            AzureBiblioteca db = new AzureBiblioteca();
            List<tb_livro> livro = db.tb_livro.ToList();
            cbolivro.ValueMember = nameof(tb_livro.id_livro);
            cbolivro.DisplayMember = nameof(tb_livro.ds_titulo);
            cbolivro.DataSource = livro;
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            ConsultarAluno();
            ConsultarLocatario();
        }

        private void rdnlocatorio_CheckedChanged(object sender, EventArgs e)
        {
            if(rdnlocatorio.Checked ==true)
            {
                mktCPF.Enabled = true;
                txtaluno.Enabled = false;
            }
        }

        private void rdnaluno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdnaluno.Checked==true)
            {
                txtaluno.Enabled = true;
                mktCPF.Enabled = false;
            }
        }
    }
}
