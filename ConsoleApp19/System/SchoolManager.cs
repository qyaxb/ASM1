using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class SchoolManager
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<Course> courses;

        public SchoolManager()
        {
            teachers = new List<Teacher>();
            students = new List<Student>();
            courses = new List<Course>();
        }

        // Add a teacher to the system
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        // Add a student to the system
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Add a course to the system
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public IEnumerable<Teacher> GetTeachers()
        {
            return teachers;
        }

        // Get all students
        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        // Get all courses
        public IEnumerable<Course> GetCourses()
        {
            return courses;
        }

        // Display the list of teachers
        public void DisplayTeachers()
        {
            Console.WriteLine("List of Teachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.Id}, Name: {teacher.Name}, Department: {teacher.Department}");
            }
        }

        // Display the list of students
        public void DisplayStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }

        // Display the list of courses
        public void DisplayCourses()
        {
            Console.WriteLine("List of Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id}, Name: {course.Name}, Teacher: {course.Teacher.Name}");
            }
        }
    }

}
