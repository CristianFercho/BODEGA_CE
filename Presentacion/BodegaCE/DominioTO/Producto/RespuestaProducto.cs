using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO.Producto
{
    public class RespuestaProducto
    {
        public Guid ProductoId { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
