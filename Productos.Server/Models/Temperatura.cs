using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biodigestor.Server.Models
{
    public class Temperatura
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 2")]
        [DisplayFormat(DataFormatString = "{0 : C2}")]
        public decimal Temp { get; set; }

    }
}
