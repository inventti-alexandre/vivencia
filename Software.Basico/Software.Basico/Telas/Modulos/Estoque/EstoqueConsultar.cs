using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Estoque
{
    public partial class EstoqueConsultar : UserControl
    {
        public EstoqueConsultar()
        {
            InitializeComponent();
        }
        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnAlterar.BackColor = Tema.Segundaria;
           
                btnRemover.BackColor = Tema.Segundaria;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EstoqueCadastrar frm = new EstoqueCadastrar();
            ((frmPrincipal)this.ParentForm).CarregarPanel(frm);
           
        }

        private void EstoqueConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
