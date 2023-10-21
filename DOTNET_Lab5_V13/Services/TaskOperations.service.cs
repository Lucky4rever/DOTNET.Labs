using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source;
using DOTNET_Lab5_V13.Source.Status;
using Task = DOTNET_Lab5_V13.Source.Task;
using System.Collections.Generic;
using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Services
{
    class TaskOperations
    {

        public void SetTaskForStudents(List<IStudent> students, ITask task)
        {
            foreach (Student student in students)
            {
                student.SetTask(task);
            }
        }

        public void CheckStudentWorks(List<IStudent> students, string answer)
        {
            foreach (Student student in students)
            {
                Task task = (Task)student.GetTask();

                if (task == null)
                {
                    throw new NoTaskException();
                }

                var solution = task.GetSolution();

                task.SetStatus(new Submitted());

                if (solution == null)
                {
                    task.SetStatus(new Incompleted());
                    continue;
                }

                if (solution == answer)
                {
                    task.SetStatus(new Completed());
                    continue;
                }

                task.SetStatus(new NeedToResubmit());
            }
        }
    }
}
