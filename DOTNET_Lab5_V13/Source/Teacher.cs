using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using DOTNET_Lab5_V13.Source.Status;
using System.Collections.Generic;

namespace DOTNET_Lab5_V13.Source
{
    class Teacher : Person, ITeacher
    {
        private List<IStudent> _students;

        public Teacher(string name) : base(name)
        {
            this._students = new List<IStudent>();
        }

        public List<IStudent> GetStudents()
        {
            return this._students;
        }

        public void AddStudent(IStudent student)
        {
            this._students.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            this._students.Remove(student);
        }

        public void SetStudentAssessment(IStudent student, int assessment)
        {
            Task task = (Task)student.GetTask();
            StatusFactory factory = new StatusFactory();

            if (task == null)
            {
                throw new NoTaskException();
            }

            student.IncreaseAssessment(assessment);
            task.SetStatus(factory.Checked());
        }
    }
}
