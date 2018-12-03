using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.Modulos.Editora
{
    public partial class frmCadastrar : UserControl
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }
        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;

            btnCadastrar.BackColor = Tema.Segundaria;
            btnRemover.BackColor = Tema.Segundaria;
            //btnRemover.BackColor = Tema.Segundaria;
        }
        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
