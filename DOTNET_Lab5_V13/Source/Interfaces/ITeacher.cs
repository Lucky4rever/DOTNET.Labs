using System.Collections.Generic;

namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface ITeacher
    {
        void AddStudent(IStudent student);
        void RemoveStudent(IStudent student);
        void CheckStudentWorks(string answer, int assessment);
        void SetTaskForStudents(ITask task);
    }
}
