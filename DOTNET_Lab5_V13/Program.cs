using DOTNET_Lab5_V13.Services;
using DOTNET_Lab5_V13.Source;
using DOTNET_Lab5_V13.Source.Interfaces;
using DOTNET_Lab5_V13.Source.Status;
using System;
using System.Collections.Generic;

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
            TaskOperations taskOperations = new TaskOperations();

            Teacher teacher = new Teacher("Eugenii Vovk");

            Student student1 = new Student("Pavlo Snigur");
            Student student2 = new Student("Andrii Semko");
            Student student3 = new Student("Vlad Tkach");

            teacher.AddStudent(student1);
            teacher.AddStudent(student2);
            teacher.AddStudent(student3);

            taskOperations.SetTaskForStudents(teacher.Students, new Task("2+2=?"));

            Console.WriteLine("Checking solutions and setting work status\n");

            student1.SetTaskSolution("4");
            student2.SetTaskSolution("5");

            taskOperations.CheckStudentWorks(teacher.Students, "4");

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine("Setting assessment\n");

            teacher.SetStudentAssessment(student1, 12);

            Console.WriteLine(student1);
        }
    }
}
