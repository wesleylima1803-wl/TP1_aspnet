using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"Gravando no arquivo 'xxxx.xyz': {message}");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"Executando ação na tabela 'xxxx' do Banco de Dados: {message}");
        }
    }
}
