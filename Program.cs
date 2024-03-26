namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Run();

            Console.WriteLine("\nProgram will exit.\n");
            Console.ReadLine();
        }
    }
}
