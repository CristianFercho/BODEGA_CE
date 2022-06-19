using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Producto
    {
        public Guid ProductoId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<MovimientoEntrada> bodegaLink { get; set; }
    }
}
