using DominioTO.Producto;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia.Producto
{
    public class ProductoDM : ProductoIDM
    {
        private readonly string cadenaConexion;
        private readonly IConfiguration config;

        public ProductoDM(IConfiguration config)
        {
            this.config = config;
            this.cadenaConexion = this.config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<ProductoTO> GetProductos()
        {
            using (IDbConnection db = new SqlConnection(this.cadenaConexion))
            {
                //var data = db.Query<ProductoTO>("dbo.usp_ConsultarProductos", commandType: CommandType.StoredProcedure);
                var lista = new List<ProductoTO>();
                return lista;
            }
        }
    }
}
