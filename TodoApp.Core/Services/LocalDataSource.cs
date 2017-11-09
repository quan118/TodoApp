using System;
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
    }
}
