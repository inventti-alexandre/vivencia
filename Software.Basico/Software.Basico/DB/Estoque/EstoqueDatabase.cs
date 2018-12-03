using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Estoque
{
    class EstoqueDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();

        public void CadastrarnoEstoque(tb_estoque dto)
        {
            db.tb_estoque.Add(dto);
            db.SaveChanges();

        }

        public void AlterarEStoque(tb_estoque dto, int idEstoque)
        {
            tb_estoque estoque = db.tb_estoque.Where(x => x.id_estoque == idEstoque).ToList().Single();

            estoque.qtd_livro = dto.qtd_livro;
            db.SaveChanges();

        }
        public void RemoverEstoque(int idEstoque)
        {
            var Est = new tb_estoque { id_estoque = idEstoque };
            db.Entry(Est).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public List<tb_estoque> ConsultarEstoque()
        {
            List<tb_estoque> funclist = db.tb_estoque.ToList();
            return funclist;
        }
        public tb_estoque ConsultarEstoquePorid(int IdEstoque)
        {
            tb_estoque Estoque = db.tb_estoque.Where(x => x.id_estoque == IdEstoque).ToList().Single();
            return Estoque;
        }
        public tb_estoque ConsultarLivroPorid(int IdLivro)
        {
            tb_estoque EstoqueLivro = db.tb_estoque.Where(x => x.tb_livro_id_livro == IdLivro).ToList().Single();
            return EstoqueLivro;
        }
    }
}
