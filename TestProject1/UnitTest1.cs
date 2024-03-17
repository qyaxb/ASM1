using ConsoleApp19;
using System.Linq;
namespace TestProject1
{
    public class SchoolManagerTests
    {
        [Test]
        public void AddTeacher_ShouldAddTeacherToList()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var teacher = new Teacher(1, "John Doe", "Mathematics");

            // Act
            schoolManager.AddTeacher(teacher);

            // Assert
            Assert.AreEqual(1, schoolManager.GetTeachers().Count());
            Assert.AreEqual(teacher, schoolManager.GetTeachers().First());
        }

        [Test]
        public void AddStudent_ShouldAddStudentToList()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var student = new Student(1, "Alice");

            // Act
            schoolManager.AddStudent(student);

            // Assert
            Assert.AreEqual(1, schoolManager.GetStudents().Count());
            Assert.AreEqual(student, schoolManager.GetStudents().First());
        }

        [Test]
        public void AddCourse_ShouldAddCourseToList()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var teacher = new Teacher(1, "John Doe", "Mathematics");
            var course = new Course(1, "Math101", teacher);

            // Act
            schoolManager.AddCourse(course);

            // Assert
            Assert.AreEqual(1, schoolManager.GetCourses().Count());
            Assert.AreEqual(course, schoolManager.GetCourses().First());
        }

        [Test]
        public void DisplayTeachers_ShouldDisplayListOfTeachers()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var teacher1 = new Teacher(1, "John Doe", "Mathematics");
            var teacher2 = new Teacher(2, "Jane Smith", "Physics");
            schoolManager.AddTeacher(teacher1);
            schoolManager.AddTeacher(teacher2);

            // Act
            Console.WriteLine("Displaying Teachers:");
            schoolManager.DisplayTeachers();

            // Assert - Since this is a display method, we cannot directly assert. We'll just check if it runs without throwing an exception.
            Assert.Pass();
        }

        [Test]
        public void DisplayCourses_ShouldDisplayListOfCourses()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var teacher = new Teacher(1, "John Doe", "Mathematics");
            var course1 = new Course(1, "Math101", teacher);
            var course2 = new Course(2, "Physics101", teacher);
            schoolManager.AddCourse(course1);
            schoolManager.AddCourse(course2);

            // Act
            Console.WriteLine("Displaying Courses:");
            schoolManager.DisplayCourses();

            // Assert - Since this is a display method, we cannot directly assert. We'll just check if it runs without throwing an exception.
            Assert.Pass();
        }
        [Test]
        public void AddDuplicateTeacher_ShouldThrowException()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var teacher1 = new Teacher(1, "John Doe", "Mathematics");
            var teacher2 = new Teacher(1, "Jane Smith", "Physics"); // Duplicate ID

            // Act & Assert
            Assert.Throws<ArgumentException>(() => schoolManager.AddTeacher(teacher1));
            Assert.Throws<ArgumentException>(() => schoolManager.AddTeacher(teacher2));
        }

        [Test]
        public void AddCourseWithoutTeacher_ShouldThrowException()
        {
            // Arrange
            var schoolManager = new SchoolManager();
            var course = new Course(1, "Math101", null); // No teacher assigned

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => schoolManager.AddCourse(course));
        }
    }
}
