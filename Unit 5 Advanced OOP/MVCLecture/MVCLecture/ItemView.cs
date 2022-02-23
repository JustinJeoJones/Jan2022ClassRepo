using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemView
    {
        public Item DisplayItem { get; set; }

        public ItemView(Item _displayItem)
        {
            DisplayItem = _displayItem;
        }
        //display
        public void Display()
        {
            Console.WriteLine($"{DisplayItem.Name} ${DisplayItem.Price}");
        }
    }
}
