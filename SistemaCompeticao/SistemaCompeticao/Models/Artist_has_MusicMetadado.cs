using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(Artist_has_Music))]
    public partial class Artist_has_Music { }

    public class Artist_has_MusicMetadado
    {
        [Required(ErrorMessage = "O artista é obrigatório")]
        public int Artist_idArtist { get; set; }

        [Required(ErrorMessage = "A música é obrigatória")]
        public int idMusic { get; set; }
    }
}