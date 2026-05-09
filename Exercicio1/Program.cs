namespace Exercicio1
{
    internal class Program
    {
        public delegate decimal CalculateDiscount(decimal price);
        static void Main(string[] args)
        {
            Console.WriteLine("--- Módulo de Regras de Negócio: Descontos ---");

            // 2. Solicita ao usuário que informe o preço original
            Console.Write("Informe o preço original do produto: R$ ");
            string input = Console.ReadLine();

            // Valida se a entrada é um número decimal válido
            if (decimal.TryParse(input, out decimal precoOriginal))
            {
                // 3. Instancia o delegate apontando para o método compatível
                CalculateDiscount calcular = AplicarDescontoDezPorcento;

                // 4. Utiliza o delegate no fluxo da aplicação para calcular o valor final
                decimal precoFinal = calcular(precoOriginal);

                // 5. Exibe o valor final ao usuário
                Console.WriteLine("\n--- Resultado ---");
                Console.WriteLine($"Preço original: R$ {precoOriginal:F2}");
                Console.WriteLine($"Preço com 10% de desconto: R$ {precoFinal:F2}");
            }
            else
            {
                Console.WriteLine("Erro: Por favor, insira um valor numérico válido.");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // Método compatível com a assinatura do delegate CalculateDiscount
        public static decimal AplicarDescontoDezPorcento(decimal preco)
        {
            // Calcula o desconto de 10%
            decimal desconto = preco * 0.10m;
            return preco - desconto;
        }
    }
}
    }
}
