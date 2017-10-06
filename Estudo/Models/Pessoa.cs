using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Models
{
    public class Pessoa
    {
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo.")]
        [StringLength(200, ErrorMessage = "Digite no máximo 20 caracteres.")]
        public virtual string Nome { get; set; }

        [Required(ErrorMessage = "por favor preencha o Conteúdo.")]
        [StringLength(20, ErrorMessage = "Digite no máximo 20 caracteres.")]
        public virtual string CpfCnpj { get; set; }

        [Required(ErrorMessage = "por favor preencha o Conteúdo.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public virtual DateTime DataNascimento { get; set; }
    }
}