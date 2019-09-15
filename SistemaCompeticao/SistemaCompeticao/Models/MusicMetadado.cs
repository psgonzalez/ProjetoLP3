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
        [Display(Name = "Título da Música")]
        [Required(ErrorMessage = "O título da música é obrigatório")]
        public string Title { get; set; }

        [Display(Name = "Duração")]
        [Required(ErrorMessage = "A duração é obrigatória")]
        public System.TimeSpan MusicLength { get; set; }

        [Display(Name = "Gênero Musical")]
        [Required(ErrorMessage = "O gênero musical é obrigatório")]
        public string Genre { get; set; }
    }
}