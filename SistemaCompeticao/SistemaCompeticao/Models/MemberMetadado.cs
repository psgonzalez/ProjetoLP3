using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCompeticao.Models
{
    [MetadataType(typeof(MemberMetadado))]
    public partial class Member { }

    public class MemberMetadado
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        public System.DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "O artista é obrigatório")]
        public int Artist_idArtist { get; set; }
    }
}