//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Software.Basico.DB.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_emprestimo
    {
        public int id_emprestimo { get; set; }
        public System.DateTime dt_emprestimo { get; set; }
        public System.DateTime dt_devolucao { get; set; }
        public string nm_funcionario { get; set; }
        public int livro_id_livro { get; set; }
        public int tb_turma_aluno_id_turma_aluno { get; set; }
    
        public virtual tb_livro tb_livro { get; set; }
        public virtual tb_turma_aluno tb_turma_aluno { get; set; }
    }
}