namespace ToDoApp
{
    internal class Task
    {
        public string Name { get;  }
        public DateTime DueDate { get; private set; }
        public bool isDone { get; private set; }

        public void MarkDone()
        {
            isDone = true;
        }
    }
}
