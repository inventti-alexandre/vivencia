using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Autor
{
    class AutorDatabase
    {
        BibliotecaDBAzure db = new BibliotecaDBAzure();

        public void CadastrarAutor(tb_Autor dto)
        {
            db.tb_Autor.Add(dto);
            db.SaveChanges();
            

        }
        public void AlterarFuncionario(tb_Autor dto,int id_Autor)
        {
            tb_Autor func = db.tb_Autor.WHERE(x => x.id_Autor == id_Autor).Tolist().Single();
            func.nm_autor = dto.nm_autor
        }
    }
}
