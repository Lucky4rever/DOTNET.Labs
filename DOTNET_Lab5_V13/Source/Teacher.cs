using DOTNET_Lab5_V13.Source.Interfaces;
using DOTNET_Lab5_V13.Source.Status;
using System.Collections.Generic;

namespace DOTNET_Lab5_V13.Source
{
    class Teacher : Person, ITeacher
    {
        private IList<IStudent> Students { get; set; }

        public Teacher(string name) : base(name)
        {
            this.Students = new List<IStudent>();
        }

        public void AddStudent(IStudent student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            this.Students.Remove(student);
        }

        public void CheckStudentWorks(string answer, int assessment)
        {
            foreach (Student student in this.Students)
            {
                Task task = (Task)student.GetTask();
                var solution = task.GetSolution();

                task.SetStatus(new Submitted());

                if (solution == null)
                {
                    task.SetStatus(new Incompleted());
                    continue;
                }

                if (solution == answer)
                {
                    task.SetStatus(new Checked());
                    student.IncreaseAssessment(assessment);
                    continue;
                }

                task.SetStatus(new NeedToResubmit());
            }
        }

        public void SetTaskForStudents(ITask task)
        {
            foreach (Student student in this.Students)
            {
                student.SetTask(task);
            }
        }
    }
}
