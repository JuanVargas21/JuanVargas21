using Anun.API.Data;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Anun.API.Controllers
{
    [ApiController]
    [Route("/api/webs")]
    public class WebsController : ControllerBase
    {

        private readonly DataContext _context;
        public WebsController(DataContext context)
        {

            _context = context;

        }

        // Get por lista (muestra todos los registros)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Webs.ToListAsync());
        }


        //get por parametro. Se ingresa el id
        [HttpGet("{Id:int}")]

        public async Task<ActionResult> Get(int Id)
        {
            var web = await _context.Webs.FirstOrDefaultAsync(x => x.Id == Id);
            if (web == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(web);
            }
        }


        //delete - Elminar un registro
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var filasEliminadas = await _context.Webs
            .Where(a => a.Id == Id)
            .ExecuteDeleteAsync();  // Eliminar directamente con ExecuteDeleteAsync


            if (filasEliminadas == 0)
            {
                return NotFound();

            }
            else
            {
                return NoContent();
            }
        }


        //put modificar datos
        [HttpPut]

        public async Task<ActionResult> Put(Web web)
        {
            _context.Update(web);
            await _context.SaveChangesAsync();

            return Ok(web);
        }

        // Post para insertar valores
        [HttpPost]

        public async Task<ActionResult> Post(Web web)
        {
            _context.Add(web);
            await _context.SaveChangesAsync();

            return Ok(web);
        }
    }
}
