namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para fazer o Cálculo de Área");

            Console.Write("\nInforme a base do retângulo (em metros): ");
            string baseRetanguloUsuario = Console.ReadLine();

            Console.Write("Informe a altura do retângulo (em metros): ");
            string alturaRetanguloUsuario = Console.ReadLine();

            if (double.TryParse(baseRetanguloUsuario, out double baseRetangulo) &&
                double.TryParse(alturaRetanguloUsuario, out double alturaRetangulo))
            {
                Func<double, double, double> calcularArea = (b, h) => b * h;

                double areaCalculada = calcularArea(baseRetangulo, alturaRetangulo);

                Console.WriteLine("\nCálculo concluído:");
                Console.WriteLine($"\nBase informada: {baseRetangulo:F2} m");
                Console.WriteLine($"Altura informada: {alturaRetangulo:F2} m");
                Console.WriteLine($"Área do retângulo: {areaCalculada:F2} m²");
            }
            else
            {
                Console.WriteLine("Por favor, insira números válidos para a base e a altura(em decimal).");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
    
}
