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
    public class AnuncioPagina
    {
        public int Id { get; set; }
        public int AnuncioId { get; set; }
        public int WebId { get; set; }

        [Required(ErrorMessage = " la fecha inicial  es obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = " la fecha final  es obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechafinal { get; set; }

        // Propiedades de navegación
        [JsonIgnore]
        public Anuncio Anuncio { get; set; }
        [JsonIgnore]
        public Web Web { get; set; }
    }
}
