using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Transport.Entities
{
    public class RoutesWork
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        [ForeignKey("TransportType")]
        public int TypeId { get; set; }
        public virtual TransportType TransportType { get; set; }

        public double Fare { get; set; }

        public DateTime RouteStart { get; set; }

        public DateTime RouteStop { get; set; }

        public DateTime RangeOfMotion { get; set; }

        public DateTime RouteDuration { get; set; }

        public ICollection<DriverRoutes> DriverRoutes { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
