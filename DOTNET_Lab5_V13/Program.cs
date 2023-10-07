using DOTNET_Lab5_V13.Source;
using DOTNET_Lab5_V13.Source.Status;
using System;

namespace DOTNET_Lab5_V13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Variant 13\nLab 5\n");

            Var13_Lab5();

            Console.ReadKey();
        }


        static void Var13_Lab5()
        {
            StatusContext context = new StatusContext(new Issued());

            context.TransitionTo(new Checked());

            Teacher teacher = new Teacher("Eugenii Vovk");

            Student student1 = new Student("Pavlo Snigur");
            Student student2 = new Student("Andrii Semko");
            Student student3 = new Student("Vlad Tkach");

            teacher.AddStudent(student1);
            teacher.AddStudent(student2);
            teacher.AddStudent(student3);

            teacher.SetTaskForStudents(new Task("2+2=?"));

            student1.SetTaskSolution("4");
            student2.SetTaskSolution("5");

            teacher.CheckStudentWorks("4", 10);

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
        }
    }
}
