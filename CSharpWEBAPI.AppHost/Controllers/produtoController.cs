using CSharpWEBAPI.Services;
using Microsoft.AspNetCore.Mvc;
using CSharpWEBAPI.AppHost.Models;

namespace CSharpWEBAPI.AppHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET api/produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(_produtoService.Get());
        }

        // GET api/produtos/{id}
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(string id)
        {
            var produto = _produtoService.Get(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        // POST api/produtos
        [HttpPost]
        public ActionResult<Produto> Post([FromBody] Produto produto)
        {
            _produtoService.Create(produto);
            return CreatedAtAction(nameof(Get), produto);
        }

        // PUT api/produtos/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Produto produto)
        {
            _produtoService.Update(id, produto);
            return NoContent();
        }

        // DELETE api/produtos/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _produtoService.Delete(id);
            return NoContent();
        }
    }
}
