using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Funcionario
{
    class FuncionarioDatabase
    {
        BibliotecaDBAzure db = new BibliotecaDBAzure();

        public void CadastrarFuncionario(tb_Funcionario dto)
        {
            db.tb_Funcionario.Add(dto);
            db.SaveChanges();
        }

        public void AlterarFuncionario(tb_Funcionario dto, int idFuncionario)
        {
            tb_Funcionario func = db.tb_Funcionario.Where(x => x.id_funcionario == idFuncionario).ToList().Single();

            func.nm_funcionario = dto.nm_funcionario;
            func.ds_email = dto.ds_email;
            func.nu_senha = dto.nu_senha;
            func.ds_sexo = dto.ds_sexo;
            func.nu_cpf = dto.nu_cpf;

            db.SaveChanges();
        }

        public void RemoverFuncionario(int idFuncionario)
        {
            var func = new tb_Funcionario { id_funcionario = idFuncionario };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_Funcionario> ListarFuncionarios()
        {
            List<tb_Funcionario> funcList = db.tb_Funcionario.ToList();
            return funcList;
        }

        public tb_Funcionario ListarFuncionarioPorId(int idFuncionario)
        {
            tb_Funcionario func = db.tb_Funcionario.Where(x => x.id_funcionario == idFuncionario).ToList().Single();
            return func;
        }
    }
}
