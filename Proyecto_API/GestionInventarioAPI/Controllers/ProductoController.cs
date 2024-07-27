using GestionInventarioBL.Interfaces;
using GestionInventarioEntities.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionInventarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        public ProductoController(IProductoService service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProductoDto), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateStock(ProductoDto model)
        {
            if (model == null)
            {
                return (IActionResult)this.BadRequest();
            }
            ProductoDto result = await this.service.UpdateStockAsync(model);
            return (result != null) ? (IActionResult)this.Ok(result) : (IActionResult)this.BadRequest();
        }
    }
}
