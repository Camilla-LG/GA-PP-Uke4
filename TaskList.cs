namespace PPUke4
{
    internal class TaskList
    {
        public List<Task> ListOfTasks { get; set; }

        public TaskList()
        {
            ListOfTasks = new List<Task>();
        }

        public void AddTask()
        {
            Console.WriteLine("Hva slags task vil du legge til?");
            var tasks = Console.ReadLine();
            ListOfTasks.Add(new Task(tasks));
            //test = tasks;
        }

        public void ShowListOfTasks()
        {
            //ListOfTasks.Add(new Task(test));
            ListOfTasks.Add(new Task("TEST TASK"));
            foreach (var x in ListOfTasks) 
            {
                Console.WriteLine($"{x.Tasks}");
            }
            //for (var i = 0; i < ListOfTasks.Count; i++)
            //{
            //    Console.WriteLine($"{ListOfTasks[i].Tasks}");
            //}
        }

        public void DeleteTask()
        {

        }
        
    }
}