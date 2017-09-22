using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class product
    {


        [Key]

        public int producID { get; set; }

        public string Descripcion { get; set; }

        public decimal precio { get; set; }


         public DateTime ultimacompra { get; set; }

        public float stock { get; set; }



    }
}