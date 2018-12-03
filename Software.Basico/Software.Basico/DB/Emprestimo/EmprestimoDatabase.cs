using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Emprestimo
{
    class EmprestimoDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastroNovoEmprestimo(tb_emprestimo dto)
        {
            db.tb_emprestimo.Add(dto);
            db.SaveChanges();
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo)
        {
            tb_emprestimo func = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();

            func.nm_funcionario = dto.nm_funcionario;
            func.dt_devolucao = dto.dt_devolucao;
            func.dt_emprestimo = dto.dt_emprestimo;
            func.tb_livro_id_livro = dto.tb_livro_id_livro;
            func.tb_turma_aluno_id_turma_aluno = dto.tb_turma_aluno_id_turma_aluno;
            func.tb_locatario_id_locatario = dto.tb_locatario_id_locatario;
            db.SaveChanges();
        }

        public void RemoverEmprestimo(int idemprestimo)
        {
            var func = new tb_emprestimo { id_emprestimo = idemprestimo };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_emprestimo> ListarEmprestimos()
        {
            List<tb_emprestimo> funcList = db.tb_emprestimo.ToList();
            return funcList;
        }

        public tb_emprestimo ListarEmprestimosPorId(int idemprestimo)
        {
            tb_emprestimo func = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();
            return func;
        }
    }
}
