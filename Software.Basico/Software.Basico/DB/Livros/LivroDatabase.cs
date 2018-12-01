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
            tb_livro liv = db.tb_livro.Where(x => x.id_livro == idLivro).ToList().Single();
            
            liv.ds_condicoes = dto.ds_condicoes;
            liv.ds_idioma = dto.ds_idioma;
            liv.ds_palavrasChaves = dto.ds_palavrasChaves;
            liv.ds_subtitulo = dto.ds_subtitulo;
            liv.ds_tipo = dto.ds_tipo;
            liv.ds_titulo = dto.ds_titulo;
            liv.id_livro = dto.id_livro;
            liv.img_Capa = dto.img_Capa;
            liv.nm_editora = dto.nm_editora;
            liv.nu_isbn = dto.nu_isbn;
            liv.nu_volume = dto.nu_volume;
            liv.autor_id_autor = dto.autor_id_autor;
            liv.tb_genero_id_genero = dto.tb_genero_id_genero;

            db.SaveChanges();
        }

        public void RemoverLivro(int idLivro)
        {
            var liv = new tb_livro { id_livro = idLivro };
            db.Entry(liv).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_livro> ListarLivros()
        {
            List<tb_livro> livList = db.tb_livro.ToList();
            return livList;
        }

        public List<vw_Livro_Autor_Genero> ListarViewLivros()
        {
            List<vw_Livro_Autor_Genero> livList = db.vw_Livro_Autor_Genero.ToList();
            return livList;
        }

        public vw_Livro_Autor_Genero ListarLivroPorId(int idLivro)
        {
            vw_Livro_Autor_Genero liv = db.vw_Livro_Autor_Genero.Where(x => x.id_livro == idLivro).ToList().Single();
            return liv;
        }
    }
}
