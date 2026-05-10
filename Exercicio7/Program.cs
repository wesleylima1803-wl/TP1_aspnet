namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> logMulticast = null;

            Console.WriteLine("Delegate vazio...");
            logMulticast?.Invoke("\nMensagem vazia");

            Console.WriteLine("\nAdicionando métodos...");

            logMulticast += logger.LogToConsole;
            logMulticast += logger.LogToFile;

            logMulticast?.Invoke("Mensagem de log registrada.");

            Console.WriteLine("\nRemovendo todos os métodos dinamicamente:");

            logMulticast -= logger.LogToConsole;
            logMulticast -= logger.LogToFile;

            logMulticast?.Invoke("Mensagem vazia");

            Console.WriteLine("O sistema se mantém após a remoção e com os delegates nulos.");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
