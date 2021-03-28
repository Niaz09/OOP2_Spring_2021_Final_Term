using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Business Administration", "BBA");
            Student s1 = new Student("Karim", "18-38770-3", 3.45f);
            Student s2 = new Student("Rahim", "16-2352-2", 3.70f);
            Student s3 = new Student("Niaz", "12-2362-3", 3.71f);
            Course c1 = new Course("Economics", "E101");
            Course c2 = new Course("Accounting", "A104");
            Course c3 = new Course("Business Studies", "B178");

            //c1.AddStudent(s1, s2, s3);
            s1.AddCourse(c1, c2, c3);
            s1.PrintAllCourse();
            s1.DropCourse(c2);
            s1.PrintAllCourse();

            //d1.AddStudent(s1,s2,s3);
            //s1.Department.ShowInfo();
            //d1.AddStudent(s2);
            //d1.AddStudent(s3);
            //d1.PrintAllStudents();
            /*s1.Department = d1;
            s1.ShowInfo();
            s1.Department = d2;
            s1.ShowInfo();*/
            //Console.WriteLine(s1.Department.Name);
            //Console.WriteLine(s1.Department.Id);
        }
    }
}
