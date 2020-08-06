using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // First test Run With Code First and inheritanhs from both EnityBase and Ingridient.
            // I expert to see the database relationes to be as it is shown in the class diagram.
            Drink newdrink = new Drink()
            {
                name = "matai",
                Container = new Container() { MaxAmount = 300, Shape = "Small Round Glass" },
                Items = new List<Item>() { new Item() { Unit = 30, Ingridient = new Liquid() { Alcohol = true, Color = "Withe", Name = "vodka" } } }

            };
            using (var context = new CocktailsSimple())
            {
                
                if (!context.DrinkContext.Include("Items").Any(x => x.name == newdrink.name))
                {

                    context.DrinkContext.AddOrUpdate(newdrink);
                }
                context.SaveChanges();
            }


        }
    }
}
