using Anun.API.Data;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Anun.API.Controllers
{
    // Los controladores se recomienda nombrarlos con el plural de la entidad
    [ApiController]
    [Route("/api/anuncios")]
    public class AnunciosController : ControllerBase
    {

        private readonly DataContext _context;
        public AnunciosController(DataContext context)
        {

            _context = context;

        }

        // Get por lista (muestra todos los registros)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Anuncios.ToListAsync());
        }


        //get por parametro. Se ingresa el id
        [HttpGet("{Id:int}")]

        public async Task<ActionResult> Get(int Id)
        {
            var anuncio = await _context.Anuncios.FirstOrDefaultAsync(x => x.Id == Id);
            if (anuncio == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(anuncio);
            }
        }


        //delete - Elminar un registro
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var filasEliminadas = await _context.Anuncios
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

        public async Task<ActionResult> Put(Anuncio anuncio)
        {
            _context.Update(anuncio);
            await _context.SaveChangesAsync();

            return Ok(anuncio);
        }

        // Post para insertar valores
        [HttpPost]

        public async Task<ActionResult> Post(Anuncio anuncio)
        {
            _context.Add(anuncio);
            await _context.SaveChangesAsync();

            return Ok(anuncio);
        }
    }
}
