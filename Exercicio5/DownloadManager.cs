using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class DownloadManager
    {
        public event EventHandler<DownloadEventArgs> DownloadCompleted;

        public void eventoDownload(string nomeArquivo)
        {
            Console.WriteLine($"Iniciando o download de ({nomeArquivo})...");
            Console.WriteLine("Carregando...");

            Thread.Sleep(2000);

            TriggerDownloadCompleted(nomeArquivo);
        }

        protected virtual void TriggerDownloadCompleted(string nomeArquivo)
        {
            DownloadCompleted?.Invoke(this, new DownloadEventArgs(nomeArquivo));
        }
    }
}
