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
        public string NomeCategoria { get; set; } = null!;
        public string TipoCategoria { get; set; } = null!;
    }
}