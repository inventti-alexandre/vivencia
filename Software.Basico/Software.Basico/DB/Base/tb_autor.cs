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
    
    public partial class tb_autor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_autor()
        {
            this.tb_livro = new HashSet<tb_livro>();
        }
    
        public int id_autor { get; set; }
        public string nm_autor { get; set; }
        public string nm_nomeCompleto { get; set; }
        public string ds_nacionalidade { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_livro> tb_livro { get; set; }
    }
}
