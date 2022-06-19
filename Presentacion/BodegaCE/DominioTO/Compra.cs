using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Compra
    {
        public Guid CompraId { get; set; }
        public int CodigoCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaModificacion { get; set; }
        public ICollection<Proveedor> proveedorLista { get; set; }
    }
}
