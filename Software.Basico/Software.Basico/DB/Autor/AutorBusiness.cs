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
    }
}
