using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(Artist_has_Competition))]
    public partial class Artist_has_Competition { }

    public class Artist_has_CompetitionMetadado
    {
        [Required(ErrorMessage = "O artista é obrigatório")]
        public int Artist_idArtist { get; set; }

        [Required(ErrorMessage = "A batalha é obrigatória")]
        public int idBattle { get; set; }
    }
}