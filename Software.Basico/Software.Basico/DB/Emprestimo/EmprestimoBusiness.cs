using Blibioteca.Developers.Validacao.ER;
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

        public void CadastroNovoEmprestimo(tb_emprestimo dto, string ra, string email)
        {
            try
            {
                DateTime ontem = DateTime.Today;
                ontem = ontem.AddDays(-1);
                if (dto.dt_devolucao.Day - DateTime.Today.Day < 0)
                    throw new ArgumentException("Impossivel devolver um livro ontem!");

                ValidarTexto val = new ValidarTexto();
                val.ValidarEmail(email);
                val.ValidarNome(dto.nm_funcionario);

                AzureBiblioteca db = new AzureBiblioteca();
                tb_turma_aluno data = db.tb_turma_aluno.Where(x => x.cd_ra == ra).ToList().Single();

                CriarNotificacao(data, email);

                dto.tb_turma_aluno_id_turma_aluno = data.id_aluno;
                dto.tb_notificacao_id_notificacao = idNot;
                EmprestimoDB.CadastroNovoEmprestimo(dto);
            }
            catch (ArgumentException ex)
            {
                System.Windows.Forms.MessageBox.Show($"{ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int idNot;

        private void CriarNotificacao(tb_turma_aluno data, string email)
        {
            AzureBiblioteca db = new AzureBiblioteca();
            tb_aluno_dados dados = new tb_aluno_dados();
            try
            {
                dados = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == data.id_aluno).ToList().Single();

                tb_notificacao not = new tb_notificacao();
                not.bt_email5DIa = false;
                not.bt_emailAtrasado = false;
                not.bt_emailDia = false;
                not.tb_aluno_dados_id_aluno_dados = dados.id_aluno_dados;

                db.tb_notificacao.Add(not);
                db.SaveChanges();

                tb_notificacao idN = db.tb_notificacao.OrderByDescending(o => o.id_notificacao).First();

                idNot = idN.id_notificacao;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                {
                    tb_aluno_dados ad = new tb_aluno_dados();
                    ad.ds_email = email;
                    ad.tb_aluno_id_aluno = data.id_aluno;

                    db.tb_aluno_dados.Add(ad);
                    db.SaveChanges();

                    tb_aluno_dados id = db.tb_aluno_dados.OrderByDescending(o => o.id_aluno_dados).First();

                    tb_notificacao not = new tb_notificacao();
                    not.bt_email5DIa = false;
                    not.bt_emailAtrasado = false;
                    not.bt_emailDia = false;
                    not.tb_aluno_dados_id_aluno_dados = id.id_aluno_dados;

                    db.tb_notificacao.Add(not);
                    db.SaveChanges();

                    tb_notificacao idN = db.tb_notificacao.OrderByDescending(o => o.id_notificacao).First();

                    idNot = idN.id_notificacao;
                    return; 
                }
            }
        }

        public int CadastroNovoEmprestimo(tb_emprestimo dto, tb_locatario professor)
        {
            try
            {
                DateTime ontem = DateTime.Today;
                ontem = ontem.AddDays(-1);
                if (dto.dt_devolucao.Day - DateTime.Today.Day < 0)
                    throw new ArgumentException("Impossivel devolver um livro ontem!");

                ValidarTexto val = new ValidarTexto();
                val.ValidarEmail(professor.ds_email);
                val.ValidarNome(dto.nm_funcionario);
                val.ValidarNome(professor.nm_locatario);

                ValidarNumero valN = new ValidarNumero();
                valN.ValidarTelefoneCelular(professor.nu_celular);

                AzureBiblioteca db = new AzureBiblioteca();
                tb_locatario data = db.tb_locatario.Where(x => x.nu_cpf == professor.nu_cpf).ToList().Single();
                
                if (data.nm_locatario != null)
                {
                    dto.tb_locatario_id_locatario = data.id_locatario;
                    return EmprestimoDB.CadastroNovoEmprestimo(dto);
                }

                return 0;
            }
            catch (ArgumentException ex)
            {
                System.Windows.Forms.MessageBox.Show($"{ex.Message}", "Biblioteca",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                AzureBiblioteca db = new AzureBiblioteca();
                int id;

                db.tb_locatario.Add(professor);
                id = db.SaveChanges();

                dto.tb_locatario_id_locatario = id;

                return EmprestimoDB.CadastroNovoEmprestimo(dto);
            }

            return 0;
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo, tb_locatario professor)
        {
            try
            {
                AzureBiblioteca db = new AzureBiblioteca();
                tb_locatario data = db.tb_locatario.Where(x => x.nu_cpf == professor.nu_cpf).ToList().Single();

                if (data.nm_locatario != null)
                {
                    professor.id_locatario = data.id_locatario;
                    EmprestimoDB.AlterarEmprestimo(dto, idemprestimo, professor);
                }
            }
            catch (Exception)
            {
                AzureBiblioteca db = new AzureBiblioteca();
                int id;

                db.tb_locatario.Add(professor);
                id = db.SaveChanges();

                dto.tb_locatario_id_locatario = id;

                EmprestimoDB.AlterarEmprestimo(dto, idemprestimo);
            }
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo, tb_aluno_dados dados)
        {
            try
            {
                AzureBiblioteca db = new AzureBiblioteca();
                tb_aluno_dados data = db.tb_aluno_dados.Where(x => x.tb_aluno_id_aluno == dados.tb_aluno_id_aluno).ToList().Single();

                if (data.ds_email != null)
                {
                    dados.id_aluno_dados = data.id_aluno_dados;
                    EmprestimoDB.AlterarEmprestimo(dto, idemprestimo, dados);
                }
            }
            catch (Exception)
            {
                AzureBiblioteca db = new AzureBiblioteca();
                int id;

                db.tb_aluno_dados.Add(dados);
                id = db.SaveChanges();

                dto.tb_turma_aluno_id_turma_aluno = id;

                EmprestimoDB.AlterarEmprestimo(dto, idemprestimo);
            }
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
            else if (titulo != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivro(titulo, dev);
            else if (professor != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorProfessor(professor, dev);
            else if (professor != string.Empty && titulo != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorLivroProfessor(titulo, professor, dev);
            else if (professor == string.Empty && titulo == string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosLocatariosPorDevolucao();

            return emprestimo;
        }

        public List<vw_emprestimo_aluno> ListarEmprestimosAlunos(string titulo, string aluno, bool dev)
        {
            List<vw_emprestimo_aluno> emprestimo = new List<vw_emprestimo_aluno>();
            if (aluno == string.Empty && titulo == string.Empty && dev == false)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunos();
            else if (titulo != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorLivro(titulo);
            else if (aluno != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorProfessor(aluno);
            else if (aluno != string.Empty && titulo != string.Empty)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorLivroProfessor(titulo, aluno);
            else if (titulo != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorLivro(titulo, dev);
            else if (aluno != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorProfessor(aluno, dev);
            else if (aluno != string.Empty && titulo != string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorLivroProfessor(titulo, aluno, dev);
            else if (aluno == string.Empty && titulo == string.Empty && dev == true)
                emprestimo = EmprestimoDB.ListarEmprestimosAlunosPorDevolucao();

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
