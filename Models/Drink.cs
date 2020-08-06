    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace InterfacesEFConsole
{
    class Drink : EnityBase
    {        

        public string name { get; set; }

        public  Container Container { get; set; }

        public  List<Item> Items { get; set; }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }
    }
}
