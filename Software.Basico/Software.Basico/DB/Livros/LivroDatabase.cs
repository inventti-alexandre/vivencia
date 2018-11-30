using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Livros
{
    class LivroDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastrarLivro(tb_livro dto)
        {
            db.tb_livro.Add(dto);
            db.SaveChanges();
        }

        public void AlterarLivro(tb_livro dto, int idLivro)
        {
            tb_livro func = db.tb_livro.Where(x => x.id_livro == idLivro).ToList().Single();

            //Programar Alterar.

            db.SaveChanges();
        }

        public void RemoverLivro(int idLivro)
        {
            var func = new tb_livro { id_livro = idLivro };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_livro> ListarLivros()
        {
            List<tb_livro> funcList = db.tb_livro.ToList();
            return funcList;
        }

        public tb_livro ListarLivroPorId(int idLivro)
        {
            tb_livro func = db.tb_livro.Where(x => x.id_livro == idLivro).ToList().Single();
            return func;
        }
    }
}
