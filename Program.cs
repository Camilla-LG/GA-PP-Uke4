
//Lag en todo app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer

namespace PPUke4
{
    internal class Program
    {
        static bool RunProgram = true;

        static void Main()
        {
            TaskList taskListInstance = new TaskList();

            while (RunProgram)
            {
                Console.WriteLine("1: Add task   2: Delete Task   3: Show tasks    4: Exit program");
                var userInput = Console.ReadKey().KeyChar;
                switch (userInput)
                {
                    case '1':
                        taskListInstance.AddTask();
                        break;
                    case '2':
                        taskListInstance.DeleteTask();
                        break;
                    case '3':
                        taskListInstance.ShowListOfTasks();
                        break;
                    case '4':
                        RunProgram = false;
                        break;

                }
            }
        }
    }

}