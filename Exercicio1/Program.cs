namespace Exercicio1
{
    internal class Program
    {
        public delegate decimal CalculateDiscount(decimal preco);
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Descontos ");

            Console.Write("\nInforme o preço original do produto: R$ ");
            string precoProduto = Console.ReadLine();

            if (decimal.TryParse(precoProduto, out decimal precoOriginal))
            {
                CalculateDiscount calcularDesconto = aplicarDezPorCento;

                decimal precoFinal = calcularDesconto(precoOriginal);

                Console.WriteLine($"\nPreços do Produto:");
                Console.WriteLine($"Preço original: {precoOriginal:C2}");
                Console.WriteLine($"Preço com 10% de desconto: {precoFinal:C2}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        public static decimal aplicarDezPorCento(decimal preco)
        {
            decimal desconto = preco * 0.10m;
            return preco - desconto;
        }
    }
}
   
