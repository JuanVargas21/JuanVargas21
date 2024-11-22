using Anun.API.Data;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Anun.API.Controllers
{
    [ApiController]
    [Route("/api/pagos")]
    public class PagosController : ControllerBase
    {

        private readonly DataContext _context;
        public PagosController(DataContext context)
        {

            _context = context;

        }

        // Get por lista (muestra todos los registros)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Pagos.ToListAsync());
        }


        //get por parametro. Se ingresa el id
        [HttpGet("{Id:int}")]

        public async Task<ActionResult> Get(int Id)
        {
            var pago = await _context.Pagos.FirstOrDefaultAsync(x => x.Id == Id);
            if (pago == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(pago);
            }
        }


        //delete - Elminar un registro
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var filasEliminadas = await _context.Pagos
            .Where(a => a.Id == Id)
            .ExecuteDeleteAsync();


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

        public async Task<ActionResult> Put(Pago pago)
        {
            _context.Update(pago);
            await _context.SaveChangesAsync();

            return Ok(pago);
        }

        // Post para insertar valores
        [HttpPost]

        public async Task<ActionResult> Post(Pago pago)
        {
            _context.Add(pago);
            await _context.SaveChangesAsync();

            return Ok(pago);
        }
    }
}
