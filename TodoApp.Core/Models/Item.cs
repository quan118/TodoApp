using System;

namespace TodoApp.Core.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public bool IsDone { get; set; }

        public Item(int id, string title, string detail, bool isDone)
        {
            Id = id;
            Title = title;
            Detail = detail;
            IsDone = isDone;
        }

        public Item(string title, string detail)
        {
            Id = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            Title = title;
            Detail = detail;
            IsDone = false;
        }

        public override string ToString()
        {
            return string.Format("[Item: Id={0}, Title={1}, Detail={2}, IsDone={3}]", Id, Title, Detail, IsDone);
        }
    }
}
