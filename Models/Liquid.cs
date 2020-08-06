using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace InterfacesEFConsole
{
    [Table("Liquid")]
    class Liquid : Ingridient
    {        

        public string Color { get; set; }

        public bool Alcohol { get; set; }

        public Liquid()
        {

        }                
    }
}
