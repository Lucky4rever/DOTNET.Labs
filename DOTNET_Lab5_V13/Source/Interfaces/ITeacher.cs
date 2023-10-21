namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface ITeacher
    {
        void AddStudent(IStudent student);
        void RemoveStudent(IStudent student);
        void SetStudentAssessment(IStudent student, int assessment);
    }
}
