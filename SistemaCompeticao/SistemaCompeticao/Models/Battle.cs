//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaCompeticao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Battle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Battle()
        {
            this.Artist_has_Competition = new HashSet<Artist_has_Competition>();
        }
    
        public int idBattle { get; set; }
        public string Name { get; set; }
        public System.TimeSpan BattleHour { get; set; }
        public int Event_idEvent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artist_has_Competition> Artist_has_Competition { get; set; }
        public virtual Event Event { get; set; }
    }
}
