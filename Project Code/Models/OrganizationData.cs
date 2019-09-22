using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _4ALLweb.Models
{
    public class OrganizationData
    {
        [Key]
        public string OrganizationName {get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
