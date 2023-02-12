namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą litere");

            string first = Console.ReadLine();
            char.Parse(first);

            Console.WriteLine("Podaj drugą litere");

            string secound = Console.ReadLine();
            char.Parse(secound);


            Console.WriteLine("Podaj trzecią litere");

            string third = Console.ReadLine();
            char.Parse(third);

            Console.WriteLine($"Podane litery w odwrotnej kolejności: {third}, {secound}, {first} ");
        }
    }
}
