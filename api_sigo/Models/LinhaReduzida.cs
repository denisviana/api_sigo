using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_sigo.Models
{
    public class LinhaReduzida
    {
        [Key]
        public int id_linha { get; set; }
        public String nome_linha { get; set; }
        public String cod_linha { get; set; }
        public String nome_empresa { get; set; }
        public float preco { get; set; }

    }
}
