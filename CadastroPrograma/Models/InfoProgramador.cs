using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPrograma.Models
{
    public class InfoProgramador
    {

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        [Display(Name = "Nome/Name")]
        public string Nome { get; set; }
        [MaxLength(21)]
        [Required]
        [Display(Name = "Telefone/Phone (Whatsapp)")]
        public int NumeroWhats { get; set; }
        [MaxLength(100)]
        [Display(Name = "Linkedin")]
        public string Linkedin { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Cidade/City")]
        public string Local { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Portifolio")]
        public string Portifolio { get; set; }
        [Required]
        public bool HorarioManha { get; set; }
        [Required]
        public bool HorarioNoite { get; set; }
        [Required]
        public bool HorarioMadrugada { get; set; }
        [Required]
        public bool HorarioTarde { get; set; }
        [Required]
        public bool HorarioComercial { get; set; }

        [Required]
        [Display(Name = "Qual sua pretensão salarial")]
        public string Salario { get; set; }



    }
}
