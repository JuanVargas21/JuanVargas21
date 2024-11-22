using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Anun.SHARED.Entities
{
    public class AnuncioEmpleado
    {
        public int Id { get; set; }
        public int AnuncioId { get; set; }
        public int EmpleadoId { get; set; }

        [JsonIgnore]
        public Anuncio Anuncio { get; set; }
        [JsonIgnore]
        public Empleado Empleado { get; set; }

    }
}
