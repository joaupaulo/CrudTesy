using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPrograma.Models
{
    public class Habilidades
    {

        public int Id { get; set; }
        
        public int InfoProgramadorId { get; set; }
        public virtual InfoProgramador InfoProgramador { get; set; }
        public int Ionic { get; set; }

        public int ReactJS { get; set; }

        public int ReactNative { get; set; }

        public int Android { get; set; }

        public int Flutter { get; set; }

        public int Swift { get; set; }

        public int Ios { get; set; }

        public int Html { get; set; }

        public int Css { get; set; }

        public int Bootstrap { get; set; }

        public int Jquery { get; set; }

        public int AngularJs1 { get; set; }

        public int Angular { get; set; }

        public int Java { get; set; }

        public int Python { get; set; }

        public int AspMvc { get; set; }

        public int AspWebForm { get; set; }

        public int C { get; set; }

        public int Csharp { get; set; }

        public int NodeJS { get; set; }

        public int ExpressNode { get; set; }

        public int Cake { get; set; }

        public int Djanto { get; set; }

        public int Majento { get; set; }

        public int Php { get; set; }

        public int Vue { get; set; }

        public int Ruby { get; set; }

        public int MySqlServer { get; set; }

        public int MySql { get; set; }

        public int Salesforce { get; set; }

        public int Photoshop { get; set; }

        public int Ilustrator { get; set; }

        public int Seo { get; set; }

        public int Laravel { get; set; }
        [MaxLength(200)]
        public string Outros { get; set; }
    }
}