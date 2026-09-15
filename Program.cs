namespace ChristmasLights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Christmas Lights";

            ConsoleColor[] cores =
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan
            };

            int posicaoAcesa = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=== CHRISTMAS LIGHTS ===");
                Console.WriteLine();

                for (int i = 0; i < cores.Length; i++)
                {
                    Console.ForegroundColor = cores[i];

                    if (i == posicaoAcesa)
                    {
                        Console.Write("● ");
                    }
                    else
                    {
                        Console.Write("○ ");
                    }
                }

                Console.ResetColor();

                Thread.Sleep(500);

                posicaoAcesa++;

                if (posicaoAcesa == cores.Length)
                {
                    posicaoAcesa = 0;
                }
            }
        }
    }
}