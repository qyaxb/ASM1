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
                // Tạo đối tượng SchoolManagementSystem
                var schoolSystem = new SchoolManagementSystem();

                // Thêm giảng viên
                var teacher1 = new Teacher(1, "John Doe", "Mathematics");
                schoolSystem.AddTeacher(teacher1);

                // Thêm sinh viên
                var student1 = new Student(1, "Alice");
                schoolSystem.AddStudent(student1);

                // Thêm khóa học
                var course1 = new Course(1, "Math101", teacher1);
                schoolSystem.AddCourse(course1);

                // Hiển thị danh sách giảng viên
                Console.WriteLine("Danh sách giảng viên:");
                schoolSystem.ListTeachers();

                // Hiển thị danh sách sinh viên
                Console.WriteLine("\nDanh sách sinh viên:");
                schoolSystem.ListStudents();

                // Hiển thị danh sách khóa học
                Console.WriteLine("\nDanh sách khóa học:");
                schoolSystem.ListCourses();
            }
        }
    }

