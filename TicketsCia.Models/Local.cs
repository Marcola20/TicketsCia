using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Local
    {
        public int LocalId { get; set; }
        public int IngressoId { get; set; }
        public string Logradouro { get; set; } = null!;
        public string? Complemento { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string UF { get; set; } = null!;   
        public string CEP { get; set; } = null!;
    }
}