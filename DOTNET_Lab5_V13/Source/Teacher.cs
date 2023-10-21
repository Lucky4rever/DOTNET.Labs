using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using DOTNET_Lab5_V13.Source.Status;
using System.Collections.Generic;

namespace DOTNET_Lab5_V13.Source
{
    class Teacher : Person, ITeacher
    {
        public List<IStudent> Students { get; private set; }

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

        public void SetStudentAssessment(IStudent student, int assessment)
        {
            Task task = (Task)student.GetTask();

            if (task == null)
            {
                throw new NoTaskException();
            }

            student.IncreaseAssessment(assessment);
            task.SetStatus(new Checked());
        }
    }
}
