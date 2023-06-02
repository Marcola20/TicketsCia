using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsCia.Models
{
    public class Usuario
    {
        [Key] public int UsuarioId { get; set; }

        public string Nome { get; set; } = null!;

        public string Sobrenome { get; set; } = null!;

        public Int64 CPF { get; set; } = -1;

        public string Email { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public string SenhaNovamente { get; set; } = null!;

        public string Celular { get; set; } = null!;

        public Endereco Endereco { get; set; } = null!;

    }
}
