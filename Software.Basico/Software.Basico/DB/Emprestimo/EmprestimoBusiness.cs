using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Emprestimo
{
    class EmprestimoBusiness
    {
        EmprestimoDatabase EmprestimoDB = new EmprestimoDatabase();

        public void CadastroNovoEmprestimo(tb_emprestimo dto, string ra)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_turma_aluno data = db.tb_turma_aluno.Where(x => x.cd_ra == ra).ToList().Single();

            dto.tb_turma_aluno_id_turma_aluno = data.id_aluno;

            EmprestimoDB.CadastroNovoEmprestimo(dto);
        }

        public void CadastroNovoEmprestimo(tb_emprestimo dto, tb_locatario professor)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_locatario data = db.tb_locatario.Where(x => x.nu_cpf == professor.nu_cpf).ToList().Single();

            int id;

            if (data.nm_locatario == null)
            {
                db.tb_locatario.Add(professor);
                id = db.SaveChanges();

                dto.tb_locatario_id_locatario = id;

                EmprestimoDB.CadastroNovoEmprestimo(dto);
            }
            else
            {
                dto.tb_locatario_id_locatario = data.id_locatario;
                EmprestimoDB.CadastroNovoEmprestimo(dto);
            }
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo)
        {
            EmprestimoDB.AlterarEmprestimo(dto, idemprestimo);
        }

        public void RemoverEmprestimo(int idemprestimo)
        {
            EmprestimoDB.RemoverEmprestimo(idemprestimo);
        }

        public List<tb_emprestimo> ListarEmprestimos()
        {
            return EmprestimoDB.ListarEmprestimos();
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunos()
        {
            return EmprestimoDB.ListarEmprestimosAlunos();
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatarios()
        {
            return EmprestimoDB.ListarEmprestimosLocatarios();
        }

        public tb_emprestimo ListarEmprestimosPorId(int idemprestimos)
        {
            return EmprestimoDB.ListarEmprestimosPorId(idemprestimos);
        }
    }
}
