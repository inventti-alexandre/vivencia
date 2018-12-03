using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Funcionario
{
    class FuncionarioBusiness
    {
        FuncionarioDatabase db = new FuncionarioDatabase();

        public void CadastrarFuncionario(tb_Funcionario dto)
        {
            if (dto.ds_email == string.Empty)
                throw new ArgumentException("O e-mail é obrigatório!");

            if (dto.nm_funcionario == string.Empty)
                throw new ArgumentException("O e-mail é obrigatório!");

            db.CadastrarFuncionario(dto);
        }

        public void AlterarFuncionario(tb_Funcionario dto, int idFuncionario)
        {
            if (dto.ds_email == string.Empty)
                throw new ArgumentException("O e-mail é obrigatório!");

            if (dto.nm_funcionario == string.Empty)
                throw new ArgumentException("O e-mail é obrigatório!");

            db.AlterarFuncionario(dto, idFuncionario);
        }

        public void RemoverFuncionario(int idFuncionario)
        {
            if (idFuncionario == 0)
                throw new ArgumentException("Esse funcionário não existe!");

            db.RemoverFuncionario(idFuncionario);
        }

        public List<tb_Funcionario> ListarFuncionarios()
        {
            return db.ListarFuncionarios();
        }

        public tb_Funcionario ListarFuncionarioPorId(int idFuncionario)
        {
            return db.ListarFuncionarioPorId(idFuncionario);
        }
    }
}
