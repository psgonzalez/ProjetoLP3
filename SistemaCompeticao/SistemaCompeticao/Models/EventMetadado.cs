using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(EventMetadado))]
    public partial class Event { }

    public class EventMetadado
    {
        [Display(Name = "Nome do Evento")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Data do Evento")]
        [Required(ErrorMessage = "A data do evento é obrigatória")]
        public System.DateTime EventDate { get; set; }
    }
}