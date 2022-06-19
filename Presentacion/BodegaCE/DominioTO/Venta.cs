using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioTO
{
    public class Venta
    {
        public Guid VentaId { get; set; }
        
        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioVenta { get; set; }
    }
}
