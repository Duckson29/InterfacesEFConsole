using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace InterfacesEFConsole
{

    class Container
    {        
        [Key]
        public int ContainerId { get; set; }
        
        public int MaxAmount { get; set; }

        public string Shape { get; set; }

        public Container()
        {
            
        }


    }
}
