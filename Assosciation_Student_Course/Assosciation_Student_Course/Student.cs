using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public float Cgpa { get; set; }

        Department department;
        public Department Department { get; set; }
        Course[] courses;
        public int CourseCount { get; set; }


        public Student()
        {
            courses = new Course[10];
        }
        public Student(string name, string id, float cgpa)
        {
            Name = name;
            Id = id;
            Cgpa = cgpa;
            courses = new Course[10];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("CGPA: " + Cgpa);
            //Department.ShowInfo();
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (Course c in courses)
            {
                this.courses[CourseCount] = c;
                CourseCount++;
                if (CourseCount > 5) { break; }
                else { continue; }
            }
        }
        public void PrintAllCourse()
        {
            for (int i = 0; i < CourseCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
        public void DropCourse(Course course)
        {
            for (int i = 0; i < CourseCount; i++)
            {
                if (course.Id.Equals(courses[i].Id))
                {
                    for (int j = i; j < CourseCount - 1; j++)
                    {
                        courses[j] = courses[j + 1];
                    }
                }
            }
            CourseCount--;
        }

    }
}
