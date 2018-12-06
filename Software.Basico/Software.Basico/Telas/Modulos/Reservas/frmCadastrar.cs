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
using Software.Basico.DB.Reserva;
using Blibioteca.Developers.Validacao.ER;

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
            Segunranca();
        }
        int idlocatario;
        int idaluno;
        AzureBiblioteca db = new AzureBiblioteca();
        ValidarNumero validar = new ValidarNumero();
        
        private void TemaTela()
        {

            panel1.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;

            btnCadastrar.ForeColor = Tema.Texto;
            btnRemover.ForeColor = Tema.Texto;
        }

        private void PreencherDados(int idLocatario)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            vw_emprestimo_locatario loc = db.vw_emprestimo_locatario.Where(x => x.id_emprestimo == idLocatario).ToList().Single();


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
            if (rdnlocatorio.Checked == true)
            {
                if (mktCPF.Text != "   .   .   -")
                {
                    LocatorioBusiness locatorio = new LocatorioBusiness();
                    tb_locatario dto = locatorio.ListarPOrCPFLocatario(mktCPF.Text);
                    lblLocatario.Text = dto.nm_locatario;
                    idlocatario = dto.id_locatario;
                }
            }
        }

        private void ConsultarAluno()
        {
            if (rdnaluno.Checked == true)
            {
                if (txtaluno != null)
                {
                    validar.ValidarRA(txtaluno.Text);
                    try
                    { 
                        tb_turma_aluno aluno = db.tb_turma_aluno.Where(x => x.cd_ra == txtaluno.Text).ToList().Single();
                        lblAluno.Text = aluno.tb_aluno.nm_aluno;
                        idaluno = aluno.tb_aluno.id_aluno;
                    }
                    catch
                    {
                        MessageBox.Show("Esse RA é invalido.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }
            }
        }
        private void CarregarCombo()
        {
           
            List<tb_livro> livro = db.tb_livro.ToList();
            cbolivro.ValueMember = nameof(tb_livro.id_livro);
            cbolivro.DisplayMember = nameof(tb_livro.ds_titulo);
            cbolivro.DataSource = livro;
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarLocatario();
            //mktCPF.Text = string.Empty;
              
             ConsultarAluno();
                //txtaluno.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SalvarDadosLocatario()
        {
           tb_reserva dto = new tb_reserva();

            if(rdnlocatorio.Checked==true)
            {
                tb_livro livro = cbolivro.SelectedItem as tb_livro;
                dto.tb_livro_id_livro = livro.id_livro;
                dto.tb_locatario_id_locatario = idlocatario;
               // dto.tb_turma_aluno_id_turma_aluno = idaluno;
                dto.dt_reserva = DateTime.Now;
                ReservaBusiness reserva = new ReservaBusiness();
                reserva.SalvarReserva(dto);
            }

            
           
        }

        private void SalvarDadosAlunos()
        {
            tb_reserva dto = new tb_reserva();
            if (rdnaluno.Checked == true)
            {

                tb_livro livro = cbolivro.SelectedItem as tb_livro;
                dto.tb_livro_id_livro = livro.id_livro;
                //dto.tb_locatario_id_locatario = idlocatario;
                dto.tb_turma_aluno_id_turma_aluno = idaluno;
                dto.dt_reserva = DateTime.Now;
                ReservaBusiness reserva = new ReservaBusiness();
                reserva.SalvarReserva(dto);
            }

            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ActionC();
            
        }
        private void ActionC()
        {
            try
            {
                SalvarDadosAlunos();
                SalvarDadosLocatario();
                MessageBox.Show("Reserva realizada com sucesso.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
  

        private void Segunranca()
        {
            //if (lblAluno.Text== "Aluno" || lblLocatario.Text== "Locatário")
            //{
            //    btnCadastrar.Enabled = false;
                
            //}
        }

        private void cbolivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                ActionC();

        }

       
       
    }
}
