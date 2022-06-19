using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Cliente
    {
        public Guid ClienteId { get; set; } 
        public string NombreCliente { get; set; }
        public DateTime FechaCreacionCliente { get; set; }
        public Nullable<DateTime> FechaModificacion { get; set; }
    }
}
