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
        }
        }
    }

