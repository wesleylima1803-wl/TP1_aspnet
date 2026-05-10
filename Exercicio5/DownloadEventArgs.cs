using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class DownloadEventArgs : EventArgs
    {
        public string NomeArquivo { get; }

        public DownloadEventArgs(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }
    }
}
