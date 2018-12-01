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
            
            func.ds_condicoes = dto.ds_condicoes;
            func.ds_idioma = dto.ds_idioma;
            func.ds_palavrasChaves = dto.ds_palavrasChaves;
            func.ds_subtitulo = dto.ds_subtitulo;
            func.ds_tipo = dto.ds_tipo;
            func.ds_titulo = dto.ds_titulo;
            func.id_livro = dto.id_livro;
            func.img_Capa = dto.img_Capa;
            func.nm_editora = dto.nm_editora;
            func.nu_isbn = dto.nu_isbn;
            func.nu_volume = dto.nu_volume;
            func.autor_id_autor = dto.autor_id_autor;
            func.tb_genero_id_genero = dto.tb_genero_id_genero;

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

        public tb_livro ListarLivroPorTituloAutor(string titulo, int autor)
        {
            tb_livro func = db.tb_livro.Where(x => x.ds_titulo == titulo && x.autor_id_autor == autor).ToList().Single();
            return func;
        }
    }
}
