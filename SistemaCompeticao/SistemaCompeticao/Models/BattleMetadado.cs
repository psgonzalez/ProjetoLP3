using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(BattleMetadado))]
    public partial class Battle { }

    public class BattleMetadado
    {
        [Required(ErrorMessage = "O nome da batalha é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O horário da apresentação é obrigatório")]
        public System.TimeSpan BattleHour { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório")]
        public int Event_idEvent { get; set; }

        [Required(ErrorMessage = "O artista é obrigatório")]
        public int Artist_idArtist { get; set; }
    }
}