﻿using Software.Basico.DB.Base;
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

        public void AlterarLocatorio(tb_locatorio dto, int idlocatario)
        {
            tb_locatario nha = db.id_locatario.Where(x => x.id_locatario == idlocatario).ToList().Single();

            nha.nu_cpf = dto.nu_cpf;
            nha.nm_locatario = dto.nm_locatario;
            nha.nu_celular = dto.nu_celular;

            db.SaveChanges();
        }

        public void RemoverLocatorio(int idlocatorio)
        {
            var func = new tb_autor { id_locatario = idlocatorio };
            db.Entry(func).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<tb_locatariot> ListarLocatario()
        {
            List<tb_autor> funcList = db.tb_locatario.ToList();
            return funcList;
        }

        public tb_autor ListarAutorPorId(int idAutor)
        {
            tb_autor func = db.tb_autor.Where(x => x.id_autor == idAutor).ToList().Single();
            return func;
        }
    }
}
}
