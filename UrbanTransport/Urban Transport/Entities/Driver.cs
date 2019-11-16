using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Transport.Entities
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ICollection<DriverRoutes> DriverRoutes { get; set; }
    }
}
