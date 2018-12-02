using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Emprestimo
{
    class EmprestimoBusiness
    {
        EmprestimoDatabase db = new EmprestimoDatabase();

        public void CadastroNovoEmprestimo(tb_emprestimo dto)
        {
            db.CadastroNovoEmprestimo(dto);
        }

        public void AlterarEmprestimo(tb_emprestimo dto, int idemprestimo)
        {
            db.AlterarEmprestimo(dto, idemprestimo);
        }

        public void RemoverEmprestimo(int idemprestimo)
        {
            db.RemoverEmprestimo(idemprestimo);
        }

        public List<tb_emprestimo> ListarEmprestimos()
        {
            return db.ListarEmprestimos();
        }

        public tb_emprestimo ListarEmprestimosPorId(int idemprestimos)
        {
            return db.ListarEmprestimosPorId(idemprestimos);
        }
    }
}
