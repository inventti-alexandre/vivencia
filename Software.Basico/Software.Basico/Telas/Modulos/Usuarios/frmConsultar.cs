using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software.Basico.DB;
using System.Data.Entity;

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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = dgvUsuarios.CurrentRow.DataBoundItem as Funcionario;
            BibliotecaDB db = new BibliotecaDB();

            var func = new Funcionario { id_funcionario = funcionario.id_funcionario };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();

            MessageBox.Show("Funcionario Removido com sucesso!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BibliotecaDB db = new BibliotecaDB();
            List<Funcionario> funcList = db.Funcionario.ToList();

            dgvUsuarios.DataSource = funcList;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = dgvUsuarios.CurrentRow.DataBoundItem as Funcionario;

            frmCadastrar frm = new frmCadastrar();
            frm.PreencherCampos(funcionario.id_funcionario);
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }
    }
}
