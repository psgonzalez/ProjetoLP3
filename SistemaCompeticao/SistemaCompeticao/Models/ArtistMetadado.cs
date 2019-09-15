using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(ArtistMetadado))]
    public partial class Artist { }

    public class ArtistMetadado
    {
        [Display(Name = "Nome do Artista")]
        [Required(ErrorMessage = "O nome do artista é obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Ano de Formação")]
        [Required(ErrorMessage = "O ano de formação é obrigatório")]
        public string FormationYear { get; set; }
    }
}