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
    
    public partial class Artist_has_Music
    {
        public int Artist_idArtist { get; set; }
        public int Music_idMusic { get; set; }
        public int idArtist_has_Music { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Music Music { get; set; }
    }
}
