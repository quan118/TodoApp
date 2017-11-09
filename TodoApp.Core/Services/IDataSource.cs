using System;
using System.Collections.Generic;
using TodoApp.Core.Models;

namespace TodoApp.Core.Services
{
    public interface IDataSource
    {
        IList<Item> Items { get; }
        void AddItem(Item item);
        void RemoveItem(Item item);
        void RemoveItem(int itemId);
        void ClearDoneItems();
    }
}
