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

namespace Software.Basico.Telas.Modulos.Usuarios
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
            //Mudar cor dos Panel.
            panel1.BackColor = Tema.Primaria;

            //Mudar cor dos Botões.
            btnAlterar.BackColor = Tema.Segundaria;
            btnCadastrar.BackColor = Tema.Segundaria;
            btnAlterar.ForeColor = Tema.Texto;
            btnCadastrar.ForeColor = Tema.Texto;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BibliotecaDB db = new BibliotecaDB();

            Funcionario dto = new Funcionario();
            dto.nm_funcionario = txtNome.Text;
            dto.nu_cpf = txtCPF.Text;
            dto.nu_senha = txtSenha.Text;
            dto.ds_sexo = txtSexo.Text;
            dto.ds_email = txtEmail.Text;

            db.Funcionario.Add(dto);
            db.SaveChanges();

            MessageBox.Show("Funcionário Cadastrado!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            BibliotecaDB db = new BibliotecaDB();

            int id = Convert.ToInt32(lblId.Text);

            Funcionario func = db.Funcionario.ToList().Where(x => x.id_funcionario == id).Single();
            func.nm_funcionario = txtNome.Text;
            func.nu_cpf = txtCPF.Text;
            func.nu_senha = txtSenha.Text;
            func.ds_sexo = txtSexo.Text;
            func.ds_email = txtEmail.Text;

            db.SaveChanges();

            MessageBox.Show("Funcionário Alterado!");
        }

        public void PreencherCampos(int idFuncionario)
        {
            BibliotecaDB db = new BibliotecaDB();

            Funcionario funcionario = db.Funcionario.ToList().Where(x => x.id_funcionario == idFuncionario).Single();
            
            txtNome.Text = funcionario.nm_funcionario;
            txtCPF.Text = funcionario.nu_cpf;
            txtEmail.Text = funcionario.ds_email;
            txtSenha.Text = funcionario.nu_senha;
            txtSexo.Text = funcionario.ds_sexo;
            lblId.Text = funcionario.id_funcionario.ToString();
        }
    }
}
