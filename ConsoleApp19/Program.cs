using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schoolManager = new SchoolManager();

            // Add teachers
            var teacher1 = new Teacher(1, "John Doe", "Mathematics");
            schoolManager.AddTeacher(teacher1);

            // Add students
            var student1 = new Student(1, "Alice");
            schoolManager.AddStudent(student1);

            // Add courses
            var course1 = new Course(1, "Math101", teacher1);
            schoolManager.AddCourse(course1);

            // Display the list of teachers
            schoolManager.DisplayTeachers();

            // Display the list of students
            schoolManager.DisplayStudents();

            // Display the list of courses
            schoolManager.DisplayCourses();

            // Add 50 students
            for (int i = 2; i <= 51; i++)
            {
                var student = new Student(i, $"Student_{i}");
                schoolManager.AddStudent(student);
            }

            // Add 50 teachers
            for (int i = 2; i <= 51; i++)
            {
                var teacher = new Teacher(i, $"Teacher_{i}", $"Subject_{i}");
                schoolManager.AddTeacher(teacher);
            }

            // Add 50 courses
            for (int i = 2; i <= 51; i++)
            {
                var teacher = new Teacher(i, $"Teacher_{i}", $"Subject_{i}");
                var course = new Course(i, $"Course_{i}", teacher);
                schoolManager.AddCourse(course);
            }

            // Display the updated list of teachers
            schoolManager.DisplayTeachers();

            // Display the updated list of students
            schoolManager.DisplayStudents();

            // Display the updated list of courses
            schoolManager.DisplayCourses();
        }
    }
}

