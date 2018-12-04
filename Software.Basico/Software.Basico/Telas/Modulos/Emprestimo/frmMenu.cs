using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Emprestimo
{
    public partial class frmMenu : UserControl
    {
        public frmMenu()
        {
            InitializeComponent();
            TemaTela();
            Arredondar();
        }

        private void TemaTela()
        {
            pnTop.BackColor = Tema.Primaria;

        }
        private void Arredondar()
        {
            Gp gp = new Gp();

            
            btnAluno.Region = new Region(gp.graphicsPath(btnAluno));
            btnProfessor.Region = new Region(gp.graphicsPath(btnProfessor));
            

        }
        private void btnAluno_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAluno_Click_1(object sender, EventArgs e)
        {
            Aluno.frmConsultar frm = new Aluno.frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnProfessor_Click_1(object sender, EventArgs e)
        {
            Professor.frmConsultar frm = new Professor.frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);

        }
    }
}
