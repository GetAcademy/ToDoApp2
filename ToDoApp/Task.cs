namespace ToDoApp
{
    internal class Task
    {
        public string Name;
        public DateTime DueDate;
        public bool isDone;

        public void MarkDone()
        {
            isDone = true;
        }
    }
}
