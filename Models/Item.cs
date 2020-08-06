using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace InterfacesEFConsole
{
    class Item : EnityBase
    {

        public int Unit { get; set; }

        public Ingridient Ingridient { get; set; }

        public Item()
        {

        }
    }
}
