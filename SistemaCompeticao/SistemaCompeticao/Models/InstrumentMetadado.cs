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
        [Required(ErrorMessage = "O tipo de instrumento é obrigatório")]
        public string InstrumentType { get; set; }
    }
}