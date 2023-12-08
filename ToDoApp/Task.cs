namespace ToDoApp
{
    internal class Task
    {
        public string Name { get;  }
        public DateTime DueDate { get; private set; }
        public bool IsDone { get; private set; }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }

        public void MarkDone()
        {
            IsDone = true;
        }
    }
}
