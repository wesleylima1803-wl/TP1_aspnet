namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> multicastLog = logger.LogToConsole;
            multicastLog += logger.LogToFile;
            multicastLog += logger.LogToDatabase;

            Console.WriteLine("Digite a mensagem de log: ");
            string mensagem = Console.ReadLine();
            Console.WriteLine();

            multicastLog(mensagem);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
