﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {

        public string Title;
        public List<Student> Students = new List<Student>();

        private byte creditPoints;
        public byte CreditPoints
        {
            get { return creditPoints; }
            private set { creditPoints = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
        }
        private static int maxId = 1;

        private static List<Course> allCourses = new List<Course>();

        public static ImmutableList<Course> AllCourses
        {
            get { return allCourses.ToImmutableList(); }
        }

        public static string PrintList()
        {
            string result = "";
            foreach (var item in allCourses)
            {
                result += $"{item.Title}\n";
            }
            return result;
        }

        public static void AddToCourses(Course course)
        {
            allCourses.Add(course);
        }

        public Course(string title, List<Student> students, byte creditPoints)
        {
            this.Title = title;
            this.Students = students;
            this.id = Course.maxId;
            Course.maxId++;
            this.CreditPoints = creditPoints;
            Course.AllCourses.Add(this);
        }
        public Course(string title, List<Student> students) : this(title, students, 3)
        {
        }
        public Course(string title) : this(title, new List<Student>())
        {
        }

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Title} ({this.Id}) ({this.CreditPoints}stp)");
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}");
            }
            Console.WriteLine();
        }
        public static Course SearchCourseById(int id)
        {
            foreach (Course course in AllCourses)
            {
                if (id == course.Id)
                {
                    return course;
                }
            }
            return null;
        }


    }
}
