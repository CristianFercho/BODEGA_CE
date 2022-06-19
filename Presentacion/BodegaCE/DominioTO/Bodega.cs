using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Bodega
    {
        public Guid BodegaId { get; set; }
        public string NombreBodega { get; set; }
        public DateTime FechaCreacionBodega { get; set; }
        public Nullable<DateTime> FechaModificacion { get; set; }
        public string DescripcionBodega { get; set; }
        public string Ubicacion { get; set; }
        public decimal CapacidadMaxima { get; set; }
        public ICollection<MovimientoEntrada> productoLink { get; set; }
    }
}
