using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InterfacesEFConsole
{
    class CocktailsSimple : DbContext
    {

        public DbSet<Accessory> AccessoryContext { get; set; }
        public DbSet<Container> ContainerContext { get; set; }
        public DbSet<Drink> DrinkContext { get; set; }
        public DbSet<Ingridient> IngridientContext { get; set; }
        public DbSet<Item> ItemContext { get; set; }
        public DbSet<Liquid> LiquidContext { get; set; }

        public CocktailsSimple() : base(@"Cocktails")
        {

        }
    }
}
