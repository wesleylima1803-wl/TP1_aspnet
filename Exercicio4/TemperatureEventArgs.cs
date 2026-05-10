using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class TemperatureEventArgs : EventArgs
    {
        public double Temperatura { get; }
        public TemperatureEventArgs(double temperatura)
        {
            Temperatura = temperatura;
        }
    }
}
