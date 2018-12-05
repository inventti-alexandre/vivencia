using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Software.Basico.DB.Genero
{
    class GeneroDatabase
    {  
        //123 Nha testanto 123 nha
        //nha

        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastrarGenero(tb_genero dto)
        {
            db.tb_genero.Add(dto);
            db.SaveChanges();
        }


        public void AlterarGenero(tb_genero dto, int idgenero)
        {
            tb_genero nha = db.tb_genero.Where(x => x.id_genero == idgenero).ToList().Single();

            nha.nm_genero = dto.nm_genero;
            db.SaveChanges();
        }

        public void RemoverGenero(int idgenero)
        {
            var nha = new tb_genero {id_genero  = idgenero };
            db.Entry(nha).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_genero> ListarGeneros()
        {
            List<tb_genero> funcList = db.tb_genero.ToList();
            return funcList;
        }

        public tb_genero ListarAutorPorId(int IdGenero)
        {
            tb_genero func = db.tb_genero.Where(x => x.id_genero == IdGenero).ToList().Single();
            return func;
        }




    }
}
