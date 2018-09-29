using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web.Models
{
    public class Pergunta
    {
        public int ID { get; set; }

        public string Autor { get; set; }

        [Required]
        public string Descricao { get; set; }


    }
}
