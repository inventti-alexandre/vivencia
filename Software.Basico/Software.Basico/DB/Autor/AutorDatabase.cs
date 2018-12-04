using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Autor
{
    class AutorDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastrarAutor(tb_autor dto)
        {
            db.tb_autor.Add(dto);
            db.SaveChanges();
        }

        public void AlterarAutor(tb_autor dto, int idAutor)
        {
            tb_autor func = db.tb_autor.Where(x => x.id_autor == idAutor).ToList().Single();

            func.nm_autor = dto.nm_autor;
            func.nm_nomeCompleto = dto.nm_nomeCompleto;
            func.ds_nacionalidade = dto.ds_nacionalidade;

            db.SaveChanges();
        }

        public void RemoverLivro(int idAutor)
        {
            var func = new tb_autor { id_autor = idAutor };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_autor> ListarAutores()
        {
            List<tb_autor> funcList = db.tb_autor.ToList();
            return funcList;
        }

        public tb_autor ListarAutorPorId(int idAutor)
        {
            tb_autor func = db.tb_autor.Where(x => x.id_autor == idAutor).ToList().Single();
            return func;
        }


        public List<tb_autor> ListarFiltroNacionalidade(string nacionalidade)
        {
            List<tb_autor> aut = db.tb_autor.Where(x => x.ds_nacionalidade.Contains(nacionalidade)).ToList();
            return aut;
        }     

        public List<tb_autor> ListarFiltroAutorNacionalidade(string autor, string nacionalidade)
        {
            List<tb_autor> aut = db.tb_autor.Where(x => x.nm_autor.Contains(autor) && x.ds_nacionalidade.Contains(nacionalidade)).ToList();
            return aut;
        }
    }
}
