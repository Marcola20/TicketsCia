using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Endereco
    {
        [Key] public int EnderecoId { get; set; }
        [ForeignKey("UsuarioId")] public int UsuarioId { get; set; }
        public string Logradouro { get; set; } = null!;
        public string? Complemento { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string UF { get; set; } = null!;
        public string CEP { get; set; } = null!;
    }
}
