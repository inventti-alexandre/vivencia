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
    
    public partial class tb_turma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_turma()
        {
            this.tb_turma_aluno = new HashSet<tb_turma_aluno>();
        }
    
        public int id_turma { get; set; }
        public string nm_turma { get; set; }
        public string ds_periodo { get; set; }
        public int curso_id_curso { get; set; }
    
        public virtual tb_curso tb_curso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_turma_aluno> tb_turma_aluno { get; set; }
    }
}