using System;
using System.Collections.Generic;

namespace UD24_API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Dni { get; set; }
        public DateTime Fecha { get; set; } = new DateTime();

        public IEnumerable<Cliente> Clientes { get; set; }
    }
}
