/*
Please solve this question for me:( there are multiple requirements for this one question in the following)

2.Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.

3. Use /Encapsulation/ to keep many details private in each class.

4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.

5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.

6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
person specific methods). IStudentService, IInstructorService should inherit from
IPersonService.

Person:
Calculate Age of the Person
Calculate the Salary of the person, Use decimal for salary
Salary cannot be negative number
Can have multiple Addresses, should have method to get addresses

Instructor:
Belongs to one Department and he can be Head of the Department
Instructor will have added bonus salary based on his experience, calculate his
years of experience based on Join Date

Student:
Can take multiple courses
Calculate student GPA based on grades for courses
Each course will have grade from A to F

Course:
Will have list of enrolled students

Department:

Will have one Instructor as head
Will have Budget for school year (start and end Date Time)
Will offer list of courses
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversitySystem
{
    // Interfaces
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        List<string> GetAddresses();
    }

    public interface IStudentService : IPersonService
    {
        void AddCourse(Course course);
        double CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        Department Department { get; set; }
        bool IsHeadOfDepartment { get; set; }
        int CalculateExperience();
    }

    public interface ICourseService
    {
        void EnrollStudent(Student student);
    }

    public interface IDepartmentService
    {
        Instructor Head { get; set; }
        decimal Budget { get; set; }
        List<Course> Courses { get; set; }
    }

    // Abstraction and Inheritance: Base class
    public abstract class Person : IPersonService
    {
        private List<string> addresses = new List<string>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }

        public int CalculateAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public virtual decimal CalculateSalary()
        {
            if (Salary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            return Salary;
        }

        public void AddAddress(string address)
        {
            addresses.Add(address);
        }

        public List<string> GetAddresses()
        {
            return new List<string>(addresses);
        }
    }

    // Student class
    public class Student : Person, IStudentService
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public double CalculateGPA()
        {
            if (courses.Count == 0) return 0;

            double totalPoints = courses.Sum(c => c.GradePoints);
            return totalPoints / courses.Count;
        }
    }

    // Instructor class
    public class Instructor : Person, IInstructorService
    {
        public Department Department { get; set; }
        public bool IsHeadOfDepartment { get; set; }
        public DateTime JoinDate { get; set; }

        public override decimal CalculateSalary()
        {
            decimal baseSalary = base.CalculateSalary();
            int experienceYears = CalculateExperience();
            decimal bonus = experienceYears * 1000; // Example bonus calculation
            return baseSalary + bonus;
        }

        public int CalculateExperience()
        {
            return DateTime.Now.Year - JoinDate.Year;
        }
    }

    // Course class
    public class Course : ICourseService
    {
        private List<Student> enrolledStudents = new List<Student>();

        public string CourseName { get; set; }
        public double GradePoints { get; set; } // Assume GradePoints is a value from 0 to 4.0

        public void EnrollStudent(Student student)
        {
            enrolledStudents.Add(student);
        }
    }

    // Department class
    public class Department : IDepartmentService
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a student
            Student student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 1, 1)
            };
            student.AddAddress("123 Main St");

            // Create an instructor
            Instructor instructor = new Instructor
            {
                FirstName = "Jane",
                LastName = "Smith",
                DateOfBirth = new DateTime(1980, 5, 20),
                Salary = 50000,
                JoinDate = new DateTime(2010, 8, 15)
            };
            instructor.AddAddress("456 College Ave");

            // Create a course and enroll the student
            Course course = new Course { CourseName = "Math 101", GradePoints = 3.5 };
            course.EnrollStudent(student);

            // Add the course to the student
            student.AddCourse(course);

            // Create a department
            Department department = new Department
            {
                Head = instructor,
                Budget = 200000,
                StartDate = new DateTime(2023, 8, 1),
                EndDate = new DateTime(2024, 5, 31)
            };
            department.Courses.Add(course);

            // Print details
            Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Age: {student.CalculateAge()}");
            Console.WriteLine($"Addresses: {string.Join(", ", student.GetAddresses())}");
            Console.WriteLine($"GPA: {student.CalculateGPA():0.00}");

            Console.WriteLine($"\nInstructor: {instructor.FirstName} {instructor.LastName}");
            Console.WriteLine($"Age: {instructor.CalculateAge()}");
            Console.WriteLine($"Experience: {instructor.CalculateExperience()} years");
            Console.WriteLine($"Salary: {instructor.CalculateSalary():C}");
            Console.WriteLine($"Addresses: {string.Join(", ", instructor.GetAddresses())}");
            Console.WriteLine($"Head of Department: {instructor.IsHeadOfDepartment}");

            Console.WriteLine($"\nDepartment Budget: {department.Budget:C}");
            Console.WriteLine($"Courses Offered: {string.Join(", ", department.Courses.Select(c => c.CourseName))}");
        }
    }
}
