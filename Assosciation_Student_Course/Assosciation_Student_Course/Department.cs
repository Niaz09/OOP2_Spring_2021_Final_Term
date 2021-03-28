using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosciation_Student_Course
{
    class Department
    {
        public string Name { get; set; }
        public string Id { get; set; }
        private Student[] students;
        private int studentCount;
        public int StudentCount { get; set; }

        public Department()
        {
            students = new Student[40];
            StudentCount = 0;
        }
        public Department(string name, string id)
        {
            Name = name;
            Id = id;
            students = new Student[40];
        }
        //students hocche array name, StudentCount hocche ekta variable, student hocche parameter
        /*public void AddStudent(Student student)
        {
            students[StudentCount] = student;
            StudentCount++;
        }*/
        public void AddStudent(params Student[] students)
        {
            foreach (Student s in students)
            {
                this.students[StudentCount++] = s;
                s.Department = this;
            }
        }
        public void PrintAllStudents()
        {
            /*foreach loop use korbona karon there is no gurantee that there will be 40 students exactly. 
            There can also be 2 or 3 students only*/
            //So we will use traditional for loop
            /*foreach (Student s in students)
            {
                s.ShowInfo();
            }*/
            for (int i = 0; i < StudentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
        }
    }
}
