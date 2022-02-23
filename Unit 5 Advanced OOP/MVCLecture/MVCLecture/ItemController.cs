using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemController
    {
        public List<Item> Items { get; set; }

        public ItemController()
        {
            Items = new List<Item>()
            {
                new Item("Baja Blast", 2),
                new Item("Sushi", 6),
                new Item("Chicken Wings", 10),
                new Item("Bacon", 1.5),
                new Item("Tacos", 3),
                new Item("Spaghetti", 8),
                new Item("Nalesniki", 10)
            };
        }

        public void DisplayItems()
        {
            foreach(Item i in Items)
            {
                ItemView view = new ItemView(i);
                view.Display();
            }
        }

    }
}
