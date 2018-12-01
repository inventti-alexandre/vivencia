using Software.Basico.DB.Autor;
using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Genero
{
    class GeneroBusiness
    {
        GeneroDatabase db = new GeneroDatabase();

        public void CadastrarGenero(tb_genero dto)
        {

            if (dto == null)
            {
                throw new ArgumentException("Esse campo Não pode ser Nulo");
            }
          
            db.CadastrarGenero(dto);
           

        }

        public void AlterarAutor(tb_genero dto, int idgenero)
        {
            db.AlterarGenero(dto, idgenero);
        }

        public void RemoverAutor(int idgenero)
        {
            db.RemoverGenero(idgenero);
        }

        public List<tb_genero> ListarGeneros()
        {
            return db.ListarGeneros();
        }

        public tb_genero ListarGenerosPorId(int idGenero)
        {
            return db.ListarAutorPorId(idGenero);
        }
    }
}
