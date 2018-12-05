using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

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
            try
            {
                AzureBiblioteca db = new AzureBiblioteca();
                tb_locatario data = db.tb_locatario.Where(x => x.nu_cpf == professor.nu_cpf).ToList().Single();
                
                if (data.nm_locatario != null)
                {
                    dto.tb_locatario_id_locatario = data.id_locatario;
                    EmprestimoDB.CadastroNovoEmprestimo(dto);
                }
            }
            catch (Exception)
            {
                AzureBiblioteca db = new AzureBiblioteca();
                int id;

                db.tb_locatario.Add(professor);
                id = db.SaveChanges();

                dto.tb_locatario_id_locatario = id;

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

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatarios(string titulo, string professor, bool dev)
        {
            List<vw_emprestimo_locatario> emprestimo = new List<vw_emprestimo_locatario>();
            if (professor == string.Empty && titulo == string.Empty && dev == false)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatarios();
            else if (titulo != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivro(titulo);
            else if (professor != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorProfessor(professor);
            else if (professor != string.Empty && titulo != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivroProfessor(titulo, professor);
            else if (titulo != string.Empty && dev != true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivro(titulo, dev);
            else if (professor != string.Empty && dev != true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorProfessor(professor, dev);
            else if (professor != string.Empty && titulo != string.Empty && dev != true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivroProfessor(titulo, professor, dev);

            return emprestimo;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivro(string titulo)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorLivro(titulo);
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorProfessor(string professor)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorProfessor(professor);
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivroProfessor(string titulo, string professor)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorLivroProfessor(titulo, professor);
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivro(string titulo, bool dev)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorLivro(titulo, dev);
        }
        
        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorProfessor(string professor, bool dev)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorProfessor(professor, dev);
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivroProfessor(string titulo, string professor, bool dev)
        {
            return EmprestimoDB.ListarEmprestimosLocatariosPorLivroProfessor(titulo, professor, dev);
        }

        public tb_emprestimo ListarEmprestimosPorId(int idemprestimos)
        {
            return EmprestimoDB.ListarEmprestimosPorId(idemprestimos);
        }
    }
}
