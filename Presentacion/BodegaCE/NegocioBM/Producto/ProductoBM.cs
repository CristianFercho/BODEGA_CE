
using DominioTO.Producto;
using Persistencia.Producto;

namespace NegocioBM.Producto
{
    public class ProductoBM : ProductoIBM
    {
        private readonly ProductoIDM dMProducto;
        public ProductoBM(ProductoIDM dMProducto)
        {
            this.dMProducto = dMProducto;
        }
        public IEnumerable<ProductoTO> GetProductos()
        {
            return this.dMProducto.GetProductos();
        }
    }
}
