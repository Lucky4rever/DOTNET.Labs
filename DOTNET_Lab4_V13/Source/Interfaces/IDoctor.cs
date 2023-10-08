using DOTNET_Lab4_V13.Source.Resourses;

namespace DOTNET_Lab4_V13.Source.Interfaces
{
    interface IDoctor : IPerson
    {
        DoctorPosition Position { get; }
    }
}
