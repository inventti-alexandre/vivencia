using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Autor
{
    class AutorBusiness
    {
        AutorDatabase db = new AutorDatabase();

        public void CadastrarAutor(tb_autor dto)
        {
            db.CadastrarAutor(dto);
        }

        public void AlterarAutor(tb_autor dto, int idAutor)
        {
            db.AlterarAutor(dto, idAutor);
        }

        public void RemoverAutor(int idAutor)
        {
            db.RemoverLivro(idAutor);
        }

        public List<tb_autor> ListarAutores()
        {
            return db.ListarAutores();
        }

        public tb_autor ListarAutorPorId(int idAutor)
        {
            return db.ListarAutorPorId(idAutor);
        }



        public List<tb_autor> ListarAutores(string autor, string nacionalidade)
        {
            List<tb_autor> func = new List<tb_autor>();

            //Sem filtro
            if (autor == string.Empty && autor == string.Empty && nacionalidade == string.Empty)
                func = db.ListarAutores();

           

            //Filtrar por nacionalidade
            else if (autor == string.Empty && autor.Length > 0 && nacionalidade == string.Empty)
                func = db.ListarFiltroNacionalidade(autor);

            //Filtrar por autor e nacionalidade
            else if (autor.Length > 0 && autor.Length > 0 && nacionalidade == string.Empty)
                func = db.ListarFiltroAutorNacionalidade(autor, nacionalidade);


            return func;
        }


    }
}
