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
    
    public partial class tb_aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_aluno()
        {
            this.tb_aluno_dados = new HashSet<tb_aluno_dados>();
            this.tb_turma_aluno = new HashSet<tb_turma_aluno>();
        }
    
        public int id_aluno { get; set; }
        public string nm_aluno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_aluno_dados> tb_aluno_dados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_turma_aluno> tb_turma_aluno { get; set; }
    }
}
