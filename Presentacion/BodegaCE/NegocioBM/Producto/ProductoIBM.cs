using DominioTO.Producto;

namespace NegocioBM.Producto
{
    public interface ProductoIBM
    {
        IEnumerable<ProductoTO> GetProductos();
    }
}
