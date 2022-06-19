using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Proveedor
    {
        public Guid ProveedorId { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime FechaCreacionProveedor { get; set; }
        public Nullable<DateTime> FechaModificacion { get; set; }
        public Compra Compra { get; set; }
    }
}
