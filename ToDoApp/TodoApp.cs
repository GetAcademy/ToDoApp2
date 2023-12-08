namespace ToDoApp
{
    internal class TodoApp
    {
        private List<Task> _tasks = CreateTasks();

        public void Show()
        {
            Console.WriteLine("Oppgave:  Frist:    Fullført:");
            Console.WriteLine();
            for (var index = 0; index < _tasks.Count; index++)
            {
                var task = _tasks[index];
                var taskNo = index + 1;
                Console.Write(taskNo + ": ");
                if (task.IsDone)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    CreateTaskText(task);
                    Console.ResetColor();
                }
                else
                {
                    CreateTaskText(task);
                }
            }

            Console.WriteLine();
        }

        public int GetCount()
        {
            return _tasks.Count;
        }

        private static void CreateTaskText(Task task)
        {
            Console.Write(task.Name.PadRight(10));
            Console.Write(task.DueDate.ToString("dd/MM/yy"));
            Console.WriteLine(task.IsDone ? $"    Ja" : "   Nei");
        }

        private static List<Task> CreateTasks()
        {
            var taskA = new Task("Vaske", new DateTime(2023, 11, 22));
            var taskB = new Task("Rydde", new DateTime(2023, 11, 23));
            var taskC = new Task("Støvsuge", new DateTime(2023, 11, 24));
            return new List<Task> { taskA, taskB, taskC };
        }

        public void MarkDone(int taskNo)
        {
            _tasks[taskNo - 1].MarkDone();
        }

        public void AddTask(string name, DateTime dueDate)
        {
            var task = new Task(name, dueDate);
            _tasks.Add(task);
        }
    }
}
