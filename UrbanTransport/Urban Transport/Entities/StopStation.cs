using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Transport.Entities
{
    public class StopStation
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Route> Routes { get; set; }
    }
}
