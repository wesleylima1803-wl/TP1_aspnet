using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureExceeded;

        private const double limiteTemperatura = 100.0;

        public void registroLeitura(double temperaturaAtual)
        {
            Console.WriteLine($"Leitura da Temperatura Atual: {temperaturaAtual:F1}ºC");

            if (temperaturaAtual > limiteTemperatura)
            {
                TemperatureExceeded?.Invoke(this, new TemperatureEventArgs(temperaturaAtual));
            }
        }
    }
}
