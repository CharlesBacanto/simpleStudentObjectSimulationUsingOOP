namespace studentObjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student("Charles", "Bacanto", "Graduate", "BSCPE", "CPE4-A", 98.5f, 95.12f);

            s1.introduceSelf();
            Console.Write(s1.evaluateGrade());
        }
    }
}
