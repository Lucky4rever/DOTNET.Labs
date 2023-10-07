using DOTNET_Labs.Variant13.NET5.Status;
using System;

namespace DOTNET_Labs.Variant13.NET5
{
    class Lab5
    {
        private static Lab5 _instance;

        private Lab5() { }

        public static Lab5 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Lab5();
            }

            return _instance;
        }

        public void Var13_Lab5()
        {
            Console.WriteLine("Variant 13\nLab 5\n");

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
