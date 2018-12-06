using Blibioteca.Developers.Validacao;
using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Locatorio
{
    class LocatorioBusiness
    {
        LocatorioDatabase db = new LocatorioDatabase();



        public void CadastrarLocatario(tb_locatario dto)
        {
            db.CadastrarLocatorio(dto);
        }

        public void AlterarLocatario(tb_locatario dto, int idlocatario)
        {
            db.AlterarLocatorio(dto, idlocatario);
        }

        public void Removerlocatario(int idlocatario)
        {
            db.RemoverLocatorio(idlocatario);
        }

        public List<tb_locatario> ListarLocatario()
        {
            return db.ListarLocatario();
        }

        public tb_locatario ListarPOrIdLocatario(int idLocatario)
        {
            return db.ListarporIdLocatario(idLocatario);
        }

        public tb_locatario ListarPOrCPFLocatario(string cpf)
        {
            CPF cpfvalidar = new CPF();
            cpfvalidar.ValidarCPF(cpf);

            if (cpf == string.Empty)
                throw new ArgumentException("Por favor preencha o campo CPF");

            if (cpf == "   .   .   -")
            {
                throw new ArgumentException("Por favor preencha o campo CPF");
            }

            return db.ListarporLocatarioCPF(cpf);
        }
    }
}
