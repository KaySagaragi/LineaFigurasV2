//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaComun.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Atributo = new HashSet<Atributo>();
            this.Historico = new HashSet<Historico>();
        }
    
        public int ID { get; set; }
        public int ID_Figura { get; set; }
        public int ID_Color { get; set; }
        public int ID_Estado { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime Origin_Date { get; set; }
        public System.DateTime Edit_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atributo> Atributo { get; set; }
        public virtual Color Color { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Figura Figura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico> Historico { get; set; }
    }
}
