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
    
    public partial class tb_turma_aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_turma_aluno()
        {
            this.tb_emprestimo = new HashSet<tb_emprestimo>();
            this.tb_reserva = new HashSet<tb_reserva>();
        }
    
        public int id_turma_aluno { get; set; }
        public Nullable<int> id_aluno { get; set; }
        public Nullable<int> id_turma { get; set; }
        public Nullable<int> nr_chamada { get; set; }
        public string cd_ra { get; set; }
    
        public virtual tb_aluno tb_aluno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_emprestimo> tb_emprestimo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_reserva> tb_reserva { get; set; }
        public virtual tb_turma tb_turma { get; set; }
    }
}
