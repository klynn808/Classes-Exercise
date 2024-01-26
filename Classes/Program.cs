namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jeep = new Car();

            jeep.Make = "Jeep";
            jeep.Model = "Grand Cherokee";
            jeep.Year = 2024;

            // Use overridden ToString() method
            Console.WriteLine(jeep);
        }
    }
}
