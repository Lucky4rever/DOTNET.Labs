using DOTNET_Labs.Variant13.NET5.Status;
using System.Collections.Generic;

namespace DOTNET_Labs.Variant13.NET5
{
    class Teacher : Person
    {
        private List<Student> Students { get; set; }

        public Teacher(string name) : base(name)
        {
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void CheckStudentWorks(string answer, int assessment)
        {
            foreach (Student student in this.Students)
            {
                Task task = student.GetTask();
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
                    student.SetAssessment(assessment);
                    continue;
                }

                task.SetStatus(new NeedToResubmit());
            }
        }

        public void SetTaskForStudents(Task task)
        {
            foreach (Student student in this.Students)
            {
                student.SetTask(task);
            }
        }
    }
}
