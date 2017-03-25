using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_sigo.Models
{
    public class Linha
    {
        [Key]
        public int IdLinha { get; set; }
        public int IdItinerario { get; set; }
        public float tarida { get; set; }
        public String NomeLinha { get; set; }
        public String nomeempresa { get; set; }
        public String CodLinha { get; set; }
        public String Origem { get; set; }
        public String Destino { get; set; }
        public Boolean LinhaIntegrada { get; set; }

    }
}
