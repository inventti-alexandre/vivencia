//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Software.Basico.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Emprestimo
    {
        public int id_emprestimo { get; set; }
        public System.DateTime dt_emprestimo { get; set; }
        public System.DateTime dt_devolucao { get; set; }
        public int livro_id_livro { get; set; }
        public int curso_id_curso { get; set; }
        public int aluno_id_aluno { get; set; }
        public int funcionario_id_funcionario { get; set; }
    
        public virtual tb_Curso tb_Curso { get; set; }
        public virtual tb_Locatario tb_Locatario { get; set; }
        public virtual tb_Funcionario tb_Funcionario { get; set; }
        public virtual tb_Livro tb_Livro { get; set; }
    }
}