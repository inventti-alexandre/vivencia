using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Software.Basico.DB.Locatorio
{
    class LocatorioDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastrarLocatorio(tb_locatario dto)
        {
            db.tb_locatario.Add(dto);
            db.SaveChanges();
        }

        public void AlterarLocatorio(tb_locatario dto, int idlocatario)
        {

            tb_locatario nha = db.tb_locatario.Where(x => x.id_locatario == idlocatario).ToList().Single();

            nha.nu_cpf = dto.nu_cpf;
            nha.nm_locatario = dto.nm_locatario;
            nha.nu_celular = dto.nu_celular;

            db.SaveChanges();
        }

        public void RemoverLocatorio(int idlocatorio)
        {
            var func = new tb_locatario { id_locatario = idlocatorio };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_locatario> ListarLocatario()
        {
            List<tb_locatario> funcList = db.tb_locatario.ToList();
            return funcList;
        }

        public tb_locatario ListarporIdLocatario(int idlocatario)
        {
            tb_locatario func = db.tb_locatario.Where(x => x.id_locatario == idlocatario).ToList().Single();
            return func;
        }

        public tb_locatario ListarporLocatarioCPF(string CPF)
        {
            tb_locatario func = db.tb_locatario.Where(x => x.nu_cpf == CPF).ToList().Single();
            return func;
        }
    }
}

