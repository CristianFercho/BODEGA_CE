

using DominioTO.Producto;

namespace Persistencia.Producto
{
    public interface ProductoIDM
    {
        IEnumerable<ProductoTO> GetProductos();
    }
}
