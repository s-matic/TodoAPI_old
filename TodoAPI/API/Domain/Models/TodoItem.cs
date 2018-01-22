namespace API.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override bool Equals(object obj)
        {
            var todoItem = obj as TodoItem;
            if (Id == todoItem.Id && Title == todoItem.Title && Completed == todoItem.Completed)
                return true;
            
            return false;
        }
    }
}