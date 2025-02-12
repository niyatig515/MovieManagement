using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace PracticeAssignment2
{
    public class Student : IComparable<Student>
    {
        private string id;
        private string grade;

        // Constructor to initialize Student object
        public Student(string id, string grade)
        {
            this.id = id;
            this.grade = grade;
        }

        // Getter method for Student ID
        public string GetId()
        {
            return this.id;
        }

        // Getter method for Grade
        public string GetGrade()
        {
            return this.grade;
        }

        // CompareTo method for sorting
        public int CompareTo(Student other)
        {
            // First, compare by Grade (ascending)
            int gradeComparison = this.grade.CompareTo(other.GetGrade());

            // If grades are the same, compare by Student ID (ascending)
            return gradeComparison == 0 ? this.id.CompareTo(other.GetId()) : gradeComparison;
        }

        // Override ToString() for better display
        public override string ToString()
        {
            return $"ID: {id}, Grade: {grade}";
        }
    }

    public class SortStudent
    {
        public Student[] SortStudentsByGradeAndId(Student[] students)
        {
            // Sort the students based on custom comparison (Grade first, then ID)
            Array.Sort(students);
            return students;
        }

        public static void Main(string[] args)
        {
            // Sample student data
            Student[] students =
            {
                new Student("103", "B"),
                new Student("101", "A"),
                new Student("104", "C"),
                new Student("102", "A"),
                new Student("105", "B")
            };

            Console.WriteLine("Before Sorting:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Sorting students
            SortStudent sorter = new SortStudent();
            sorter.SortStudentsByGradeAndId(students);

            Console.WriteLine("\nAfter Sorting (By Grade, then ID):");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

