namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitoramento de Temperatura");

            TemperatureSensor sensorTemperatura = new TemperatureSensor();

            sensorTemperatura.TemperatureExceeded += excedeuTemperatura;

            while (true)
            {
                Console.WriteLine("\nInforme a leitura do sensor (ºC): \nDigite 'sair' para finalizar");
                string temperaturaAtual = Console.ReadLine();

                if (temperaturaAtual.Trim().ToLower() == "sair")
                {
                    break;
                }

                if (double.TryParse(temperaturaAtual, out double temperatura))
                {
                    sensorTemperatura.registroLeitura(temperatura);
                }
                else
                {
                    Console.WriteLine("\nPor favor, insira uma temperatura válida.");
                }

                Console.WriteLine("");
            }
            Console.WriteLine("\nFinalizado.");
        }

        public static void excedeuTemperatura(object sender, TemperatureEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nLimite de temperatura excedido!");
            Console.WriteLine($"ATENÇÃO! A temperatura atingiu {e.Temperatura:F1}ºC.\n");
            Console.ResetColor();
        }
    }
}