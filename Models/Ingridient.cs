using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace InterfacesEFConsole
{
    [Table("Ingridient")]
    class Ingridient : EnityBase
    {
        //[NotMapped]
        internal string Name { get; set; }
        public Ingridient()
        {

        }
    }
}
