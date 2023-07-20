using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuestroWCF.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
    }
}