using Anun.API.Data;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Anun.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [ApiController]
    [Route("/api/clientes")]
    public class ClientesController : ControllerBase
    {

        private readonly DataContext _context;
        public ClientesController(DataContext context)
        {

            _context = context;

        }

        // Get por lista (muestra todos los registros)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Clientes.ToListAsync());
        }


        //get por parametro. Se ingresa el id
        [HttpGet("{Id:int}")]

        public async Task<ActionResult> Get(int Id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(x => x.Id == Id);
            if (cliente == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(cliente);
            }
        }


        //delete - Elminar un registro
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var filasEliminadas = await _context.Clientes
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

        public async Task<ActionResult> Put(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();

            return Ok(cliente);
        }

        // Post para insertar valores
        [HttpPost]

        public async Task<ActionResult> Post(Cliente cliente)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();

            return Ok(cliente);
        }
    }
}
