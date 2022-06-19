using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class MovimientoEntrada
    {
        public Guid ProductoBodegaId { get; set; }
        public Guid ProductoId { get; set; }
        public Guid BodegaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Nullable<DateTime> FechaModificacion { get; set; }
        public decimal CapacidadMaxima { get; set; }
        public Bodega bodega { get; set; }
        public Producto producto { get; set; }
    }
}
