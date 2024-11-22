using Anun.API.Data;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Anun.API.Controllers
{
    [ApiController]
    [Route("/api/empleados")]
    public class EmpleadosController : ControllerBase
    {

        private readonly DataContext _context;
        public EmpleadosController(DataContext context)
        {

            _context = context;

        }

        // Get por lista (muestra todos los registros)
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Empleados.ToListAsync());
        }


        //get por parametro. Se ingresa el id
        [HttpGet("{Id:int}")]

        public async Task<ActionResult> Get(int Id)
        {
            var empleado = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == Id);
            if (empleado == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(empleado);
            }
        }


        //delete - Elminar un registro
        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var filasEliminadas = await _context.Empleados
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

        public async Task<ActionResult> Put(Empleado empleado)
        {
            _context.Update(empleado);
            await _context.SaveChangesAsync();

            return Ok(empleado);
        }

        // Post para insertar valores
        [HttpPost]

        public async Task<ActionResult> Post(Empleado empleado)
        {
            _context.Add(empleado);
            await _context.SaveChangesAsync();

            return Ok(empleado);
        }
    }
}
