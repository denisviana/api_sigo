using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_sigo.Models
{
    public class Parada
    {
        [Key]
        public int idparada { get; set; }
        public int iditinerario { get; set; }
        public String nomeparada { get; set; }

    }
}
