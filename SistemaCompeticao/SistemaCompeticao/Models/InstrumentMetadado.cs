using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(InstrumentMetadado))]
    public partial class Instrument { }

    public class InstrumentMetadado
    {
        [Display(Name = "Tipo de Instrumento")]
        [Required(ErrorMessage = "O tipo de instrumento é obrigatório")]
        public string InstrumentType { get; set; }

        [Required(ErrorMessage = "A música é obrigatória")]
        public int Music_idMusic { get; set; }

        [Required(ErrorMessage = "O membro é obrigatório")]
        public int Member_idMember { get; set; }
    }
}