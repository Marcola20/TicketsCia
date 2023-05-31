using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}