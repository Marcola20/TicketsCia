using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Ticket
    {
        [Key] public int IngressoId { get; set; }
        [ForeignKey("UsuarioId")] public int UsuarioId { get; set; }
        [ForeignKey("CategoriaId")] public int CategoriaId { get; set; }
        public string NomeEvento { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string? Empresa { get; set; }
        public Local Local { get; set; } = null!;
    }
}