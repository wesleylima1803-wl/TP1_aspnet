namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DownloadManager manager = new DownloadManager();
            manager.DownloadCompleted += downloadConcluido;

            Console.Write("\nInforme o nome do arquivo: ");
            string nomeArquivo = Console.ReadLine();

            Console.WriteLine();

            manager.eventoDownload(nomeArquivo);

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }

        static void downloadConcluido(object sender, DownloadEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nO download de '{e.NomeArquivo}' foi finalizado com sucesso.");
            Console.ResetColor();
        }
    }
}
