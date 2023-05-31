using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Ticket
    {
        [Key]
        public int IngressoId { get; set; }
        public string NomeEvento { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string? Empresa { get; set; }
        public Categoria? Categoria { get; set; }
        public Local? Local { get; set; }

    }
}