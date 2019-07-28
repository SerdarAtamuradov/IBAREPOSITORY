using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();
            int i;           
            Console.WriteLine("Enter please quantity of Marks-->");
            Student1.n = int.Parse(Console.ReadLine());
            Student1.Marks = new Mark[Student1.n];

            
            Console.WriteLine("Enter please name, surname and age of student-->");
            Student1.Name = Console.ReadLine();
            Student1.Surname = Console.ReadLine();
            Student1.Age = byte.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter please Marks of student-->");
            for (i = 0; i < Student1.Marks.Length; i++)
            {
                Student1.Marks[i] = new Mark();
                Console.WriteLine("Subject-->");
                Student1.Marks[i].Subject = Console.ReadLine();
                Console.WriteLine("Mark-->");
                Student1.Marks[i].SubjectMark = byte.Parse(Console.ReadLine());
            }

            Console.WriteLine("Student : {0}, {1}\nAge = {2}", Student1.Surname, Student1.Name, Student1.Age);
            Console.WriteLine("Subjects and their marks-->");
            for (i = 0; i < Student1.Marks.Length; i++)
            {
                Console.WriteLine("Subject : {0} ; Mark = {1}",Student1.Marks[i].Subject, Student1.Marks[i].SubjectMark);                
            }

            float AvgMark = Student1.GetAvgMark();
            Console.WriteLine("Average Mark Of Students = {0}",AvgMark);

            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }
    }
}
