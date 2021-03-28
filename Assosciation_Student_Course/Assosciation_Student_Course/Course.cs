using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Course
    {
        public string Name { get; set; }
        public string Id { get; set; }
        Student[] students;
        public int StudentCount { get; set; }
        public Course()
        {
            students = new Student[40];
        }
        public Course(string name, string id)
        {
            Name = name;
            Id = id;
            students = new Student[40];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
        }
        public void AddStudent(params Student[] students)
        {
            foreach (Student s in students)
            {
                this.students[StudentCount] = s;
                StudentCount++;
                if (StudentCount > 30) { break; }
                else { continue; }
            }
        }
        public void PrintAllStudent()
        {
            for (int i = 0; i < StudentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
    }

}
