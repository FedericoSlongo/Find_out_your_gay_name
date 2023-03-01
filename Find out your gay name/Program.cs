namespace Find_out_your_gay_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "!! FIND OUT YOUR GAY NAME!!";
            string nome = "", cognome = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Fi");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("nd ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ou");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("t y");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("ou");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("r g");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ay ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("na");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("me");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("!!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Write your name : ");
            nome = Console.ReadLine();
            Console.Write("Write your surname : ");
            cognome= Console.ReadLine();

            Console.Clear();

            Console.Write("You gay name is ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(600);
            }
            Console.WriteLine($"{nome} {cognome}\n");

            Console.Write("Press any button to close . . .");
            Console.ReadKey();
        }
    }
}