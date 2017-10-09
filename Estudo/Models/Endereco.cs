using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estudo.Models
{
    public class Endereco
    {
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo.")]
        [StringLength(200, ErrorMessage = "Digite no máximo 200 caracteres.")]
        public virtual string Descricao { get; set; }

        [Required(ErrorMessage = "por favor preencha o Conteúdo.")]
        [StringLength(200, ErrorMessage = "Digite no máximo 200 caracteres.")]
        public virtual string Bairro { get; set; }

        [Required(ErrorMessage = "por favor preencha o Conteúdo.")]
        [StringLength(200, ErrorMessage = "Digite no máximo 200 caracteres.")]
        public virtual string Municipio { get; set; }

        [Required(ErrorMessage = "por favor preencha o Conteúdo.")]
        [StringLength(200, ErrorMessage = "Digite no máximo 200 caracteres.")]
        public virtual string Cep { get; set; }
                
    }
}