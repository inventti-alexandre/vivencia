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
    
    public partial class Aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aluno()
        {
            this.Emprestimo = new HashSet<Emprestimo>();
        }
    
        public int id_aluno { get; set; }
        public string nm_aluno { get; set; }
        public string ds_email { get; set; }
        public string tel_fixo { get; set; }
        public string tel_celular { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
    }
}
