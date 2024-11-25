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
            Console.WriteLine("I 'am " + firstName + " " + lastName+ " a " + course+ " "+ year+ " from " + section);
        }

        //Class Method for computing average grade
        public string evaluateGrade()
        {   

            //Arithmetic Formula to get the Average
            float Average = (midtermGrade + finalGrade) / 2;
            

            //Switch Case to determine status
            switch (Average)
            {
                case (>= 90):
                    return "Honor";
            
                   
                case (>= 75):
                    return "Passed";

                case (>= 1):
                    return "Failed";
                default:
                    return "Not Applicable";


            }
        }
    }
}
