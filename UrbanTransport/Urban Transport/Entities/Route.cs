using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Transport.Entities
{
    public class Route
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RoutesWork")]
        public int RouteId { get; set; }
        public RoutesWork RoutesWork { get; set; }

        [ForeignKey("StopStation")]
        public int StopStationId { get; set; }
        public StopStation StopStation { get; set; }
    }
}
