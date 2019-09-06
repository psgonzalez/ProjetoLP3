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
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O ano de formação é obrigatório")]
        public string FormationYear { get; set; }
    }
}