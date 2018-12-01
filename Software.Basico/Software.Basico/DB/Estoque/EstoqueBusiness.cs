using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Estoque
{
    class EstoqueBusiness
    {
        EstoqueDatabase db = new EstoqueDatabase();

        public void CadastrarnoEstoque(tb_estoque dto)
        {
            db.CadastrarnoEstoque(dto);
        }

        public void AlterarEStoque(tb_estoque dto, int idEstoque)
        {
            db.AlterarEStoque(dto, idEstoque);
        }

        public void RemoverEstoque(int idEstoque)
        {
            db.RemoverEstoque(idEstoque);
        }

        public List<tb_estoque> ConsultarEstoque()
        {
            return db.ConsultarEstoque();
        }

        public tb_estoque ConsultarEstoquePorid(int IdEstoque)
        {
            return db.ConsultarEstoquePorid(IdEstoque);
        }
        public tb_estoque ConsultarLivroPorid(int IdLivro)
        {
            return db.ConsultarLivroPorid(IdLivro);
        }
    }
}
