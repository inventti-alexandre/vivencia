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

        public int CadastroNovoEmprestimo(tb_emprestimo dto)
        {
            db.tb_emprestimo.Add(dto);
            return db.SaveChanges();
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo)
        {
            tb_emprestimo emp = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();

            emp.nm_funcionario = dto.nm_funcionario;
            emp.dt_devolucao = dto.dt_devolucao;
            emp.dt_emprestimo = dto.dt_emprestimo;
            emp.bt_devolvido = dto.bt_devolvido;
            emp.tb_livro_id_livro = dto.tb_livro_id_livro;
            emp.tb_locatario_id_locatario = dto.tb_locatario_id_locatario;
            db.SaveChanges();
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo, tb_locatario locatario)
        {
            tb_locatario loc = db.tb_locatario.Where(x => x.id_locatario == locatario.id_locatario).ToList().Single();
            loc.nm_locatario = locatario.nm_locatario;
            loc.nu_celular = locatario.nu_celular;
            loc.nu_cpf = locatario.nu_cpf;
            loc.ds_email = locatario.ds_email;

            db.SaveChanges();

            tb_emprestimo emp = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();

            emp.nm_funcionario = dto.nm_funcionario;
            emp.dt_devolucao = dto.dt_devolucao;
            emp.dt_emprestimo = dto.dt_emprestimo;
            emp.bt_devolvido = dto.bt_devolvido;
            emp.tb_livro_id_livro = dto.tb_livro_id_livro;
            
            db.SaveChanges();
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo, tb_aluno_dados aluno)
        {
            tb_aluno_dados alun = db.tb_aluno_dados.Where(x => x.id_aluno_dados == aluno.id_aluno_dados).ToList().Single();
            alun.tb_aluno_id_aluno = aluno.tb_aluno_id_aluno;
            alun.ds_email = aluno.ds_email;

            db.SaveChanges();

            tb_emprestimo emp = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();

            emp.nm_funcionario = dto.nm_funcionario;
            emp.dt_devolucao = dto.dt_devolucao;
            emp.dt_emprestimo = dto.dt_emprestimo;
            emp.bt_devolvido = dto.bt_devolvido;
            emp.tb_livro_id_livro = dto.tb_livro_id_livro;

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

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunos()
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorDevolucao()
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.bt_devolvido == true).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorLivro(string titulo)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.ds_titulo.Contains(titulo)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorProfessor(string professor)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.nm_aluno.Contains(professor)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorLivroProfessor(string titulo, string professor)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.ds_titulo.Contains(titulo) && x.nm_aluno.Contains(professor)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorLivro(string titulo, bool dev)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.ds_titulo.Contains(titulo) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorProfessor(string professor, bool dev)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.nm_aluno.Contains(professor) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunosPorLivroProfessor(string titulo, string professor, bool dev)
        {
            List<vw_emprestimo_aluno> funcList = db.vw_emprestimo_aluno.Where(x => x.ds_titulo.Contains(titulo) && x.nm_aluno.Contains(professor) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        //
        public List<vw_emprestimo_locatario> ListarEmprestimosLocatarios()
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorDevolucao()
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.bt_devolvido == true).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivro(string titulo)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.ds_titulo.Contains(titulo)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorProfessor(string professor)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.nm_locatario.Contains(professor)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivroProfessor(string titulo, string professor)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.ds_titulo.Contains(titulo) && x.nm_locatario.Contains(professor)).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivro(string titulo, bool dev)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.ds_titulo.Contains(titulo) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorProfessor(string professor, bool dev)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.nm_locatario.Contains(professor) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        public List<vw_emprestimo_locatario> ListarEmprestimosLocatariosPorLivroProfessor(string titulo, string professor, bool dev)
        {
            List<vw_emprestimo_locatario> funcList = db.vw_emprestimo_locatario.Where(x => x.ds_titulo.Contains(titulo) && x.nm_locatario.Contains(professor) && x.bt_devolvido == dev).ToList();
            return funcList;
        }

        public tb_emprestimo ListarEmprestimosPorId(int idemprestimo)
        {
            tb_emprestimo func = db.tb_emprestimo.Where(x => x.id_emprestimo == idemprestimo).ToList().Single();
            return func;
        }
    }
}
