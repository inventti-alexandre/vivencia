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
    
    public partial class tb_estoque
    {
        public int id_estoque { get; set; }
        public int qtd_livro { get; set; }
        public int tb_livro_id_livro { get; set; }
    
        public virtual tb_livro tb_livro { get; set; }
    }
}
