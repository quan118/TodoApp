using System;
namespace TodoApp.Core.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public bool IsActive { get; set; }

        public Item(int id, string title, string detail, bool isActive)
        {
            Id = id;
            Title = title;
            Detail = detail;
            IsActive = isActive;
        }
    }
}
