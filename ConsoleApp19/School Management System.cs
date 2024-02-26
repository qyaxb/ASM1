using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class SchoolManagementSystem
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<Department> departments;
        private List<Course> courses;

        public SchoolManagementSystem()
        {
            teachers = new List<Teacher>();
            students = new List<Student>();
            departments = new List<Department>();
            courses = new List<Course>();
        }

        // Thêm giảng viên
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        // Thêm sinh viên
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Thêm khóa học
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        // Hiển thị danh sách giảng viên
        public void ListTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.Id}, Name: {teacher.Name}, Department: {teacher.Department}");
            }
        }

        // Hiển thị danh sách sinh viên
        public void ListStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }

        // Hiển thị danh sách khóa học
        public void ListCourses()
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id}, Name: {course.Name}, Teacher: {course.Teacher.Name}");
            }
        }
    }
}
