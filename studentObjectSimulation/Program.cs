namespace studentObjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Prompt the user to enter required inputs and store in a variable
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Year: ");
            string year = Console.ReadLine();
            Console.Write("Course: ");
            string course = Console.ReadLine();
            Console.Write("Section: ");
            string section = Console.ReadLine();
            Console.Write("Mid Term Grade: ");
            float midterm = Convert.ToSingle(Console.ReadLine());
            Console.Write("Final Grade: ");
            float finals = Convert.ToSingle(Console.ReadLine());

            //Student Object Constructor
            Student s1 = new Student(firstName, lastName, year, course, section,midterm, finals);

            Console.WriteLine();// Space
            s1.introduceSelf(); // Object Method 
            s1.evaluateGrade(); // Object Method 
        }
    }
}
