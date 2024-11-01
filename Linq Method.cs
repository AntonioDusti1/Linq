﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };
            var method = studentList.Where(s => s.StudentName.StartsWith("o"));
            foreach (var student in method)
            {
                Console.WriteLine(student.StudentName);
            }
        }

    }
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public override string ToString()
        {
            string ispis = "Redni broj:" + this.StudentID + "Ime:" + this.StudentName;
            return ispis;
        }
    } 
}

