using AutoMapper;
using DominioTO.Producto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegocioBM.Producto;

namespace BodegaCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly ProductoIBM bMProducto;
        private readonly IMapper mapper;

        [HttpGet]
        public ActionResult<IEnumerable<RespuestaProducto>> Get()
        {
            var data = this.bMProducto.GetProductos();
            var response = this.mapper.Map<IEnumerable<RespuestaProducto>>(data);

            return this.Ok(response);

        }
    }
}
