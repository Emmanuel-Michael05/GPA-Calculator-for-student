using System;
using System.Collections.Generic;

namespace GPA_Calculator_for_student
{
    // Structure to hold course information
    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public double CourseScore { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public int WeightPoint { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            int totalCourseUnits = 0;
            int totalCourseUnitsPassed = 0;
            int totalWeightPoints = 0;

            //Name of user

            Console.WriteLine("Please enter your name: ");
            string name= Console.ReadLine();
            Console.WriteLine("Welcome " + name + " thank you for using my application. Kindly answer the following questions ");

            Console.WriteLine("Enter the number of courses: ");
            int numCourses = int.Parse(Console.ReadLine());

            // Taking course data dynamically
            for (int i = 0; i < numCourses; i++)
            {
                Course course = new Course();

                Console.WriteLine($"\nEnter the name of course(e.g MTH, ENG....) {i + 1}: ");
                course.CourseName = Console.ReadLine();

                Console.WriteLine($"Enter the code of course(e.g 101, 104, 108.....) {i + 1}: ");
                course.CourseCode = Console.ReadLine();

                Console.WriteLine($"Enter the unit of course {i + 1}: ");
                course.CourseUnit = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the score for course {i + 1}: ");
                course.CourseScore = double.Parse(Console.ReadLine());

                // Calculate grade, grade unit, and weight point
                course.Grade = GetGrade(course.CourseScore);
                course.GradeUnit = GetGradeUnit(course.Grade);
                course.WeightPoint = course.CourseUnit * course.GradeUnit;

                // Adding data to totals
                totalCourseUnits += course.CourseUnit;
                totalWeightPoints += course.WeightPoint;

                if (course.GradeUnit > 0) // Passed if GradeUnit is greater than 0
                {
                    totalCourseUnitsPassed += course.CourseUnit;
                }

                courses.Add(course);
            }

            // GPA calculation
            double gpa = (double)totalWeightPoints / totalCourseUnits;

            // Printing result in tabular form using the PrintTable class
            PrintTable.Print(courses, totalCourseUnits, totalCourseUnitsPassed, totalWeightPoints, gpa);
        }

        // Method to determine the grade from the score
        static string GetGrade(double score)
        {
            if (score >= 70) return "A";
            if (score >= 60) return "B";
            if (score >= 50) return "C";
            if (score >= 45) return "D";
            if (score >= 40) return "E";
            return "F";
        }

        // Method to determine grade unit from the grade
        static int GetGradeUnit(string grade)
        {
            switch (grade)
            {
                case "A": return 5;
                case "B": return 4;
                case "C": return 3;
                case "D": return 2;
                case "E": return 1;
                case "F": return 0;
                default: return 0;
            }
        }
    }

    // Class to handle the printing of the tabular result
    class PrintTable
    {
        public static void Print(List<Course> courses, int totalUnits, int totalUnitsPassed, int totalWeightPoints, double gpa)
        {
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10} {6,-10}", "Course Code", "Course Name", "Score", "Grade", "Grade Unit", "Unit", "Weight Pt");
            Console.WriteLine("-------------------------------------------------------------------");

            foreach (var course in courses)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10} {6,-10}",
                    course.CourseCode, course.CourseName, course.CourseScore, course.Grade, course.GradeUnit, course.CourseUnit, course.WeightPoint);
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Total Course Units Registered: {totalUnits}");
            Console.WriteLine($"Total Course Units Passed: {totalUnitsPassed}");
            Console.WriteLine($"Total Weight Points: {totalWeightPoints}");
            Console.WriteLine($"Your GPA is: {gpa:F2}");
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
