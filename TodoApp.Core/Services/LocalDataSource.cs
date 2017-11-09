using System;
using System.Linq;
using System.Collections.Generic;
using TodoApp.Core.Models;

namespace TodoApp.Core.Services
{
    public class LocalDataSource : IDataSource
    {
        public IList<Item> Items { get; }

        public LocalDataSource()
        {
            Items = new List<Item>();

            Items.Add(new Item(1, "Title 1", "Detail 1", false));
            Items.Add(new Item(2, "Title 2", "Detail 2", false));
            Items.Add(new Item(3, "Title 3", "Detail 3", false));
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void RemoveItem(int itemId)
        {
            foreach (Item item in Items)
            {
                if (item.Id == itemId)
                {
                    Items.Remove(item);
                    break;
                }
            }
        }

        public void ClearDoneItems()
        {
            IList<Item> doneItems = Items.Where(item => item.IsDone == true).ToList<Item>();
            foreach (Item item in doneItems)
            {
                RemoveItem(item);
            }
        }
    }
}
