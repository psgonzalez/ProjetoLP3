using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(MusicMetadado))]
    public partial class Music { }

    public class MusicMetadado
    {
        [Required(ErrorMessage = "O título da música é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A duração é obrigatória")]
        public System.TimeSpan MusicLength { get; set; }

        [Required(ErrorMessage = "O gênero musical é obrigatório")]
        public string Genre { get; set; }
    }
}