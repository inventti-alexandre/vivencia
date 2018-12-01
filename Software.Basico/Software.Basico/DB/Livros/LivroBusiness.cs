using Software.Basico.DB.Base;
using System.Collections.Generic;

namespace Software.Basico.DB.Livros
{
    class LivroBusiness
    {
        LivroDatabase db = new LivroDatabase();

        public void CadastrarLivro(tb_livro dto)
        {
            db.CadastrarLivro(dto);
        }

        public void AlterarLivro(tb_livro dto, int idLivro)
        {
            db.AlterarLivro(dto, idLivro);
        }

        public void RemoverLivro(int idLivro)
        {
            db.RemoverLivro(idLivro);
        }

        public List<tb_livro> ListarLivros()
        {
            return db.ListarLivros();
        }

        public List<vw_Livro_Autor_Genero> ListarViewLivros()
        {
            return db.ListarViewLivros();
        }

        public vw_Livro_Autor_Genero ListarLivroPorId(int idLivro)
        {
            return db.ListarLivroPorId(idLivro);
        }
    }
}
