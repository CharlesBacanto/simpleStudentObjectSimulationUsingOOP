using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace studentObjectSimulation
{
    class Student
    {   
        //Declaration of identifiers
        public string firstName, lastName, year, course, section;
        public float midtermGrade, finalGrade;

        // Student Constructor
        public Student(string firstname, string lastName,string year, string course, string section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }


        //Class Method for introducing the student
        public void introduceSelf()
        {
            Console.WriteLine("I 'am " + firstName + " " + lastName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Year: "  + year);
            Console.WriteLine("Section: " + section);
        }

        //Class Method for computing average grade
        public void evaluateGrade()
        {   

            //Arithmetic Formula to get the Average
            float Average = (midtermGrade + finalGrade) / 2;


            if (Average > 100) Console.WriteLine("Invalid Grade");
            else if (Average >= 98) Console.WriteLine("Highest Honor");
            else if (Average >= 95) Console.WriteLine("High Honor");
            else if (Average >= 90) Console.WriteLine("Honor");
            else if (Average >= 75) Console.WriteLine("Passed");
            else Console.WriteLine("Failed");
        }
    }
}
