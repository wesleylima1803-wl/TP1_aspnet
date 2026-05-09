namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> portugues = MensagemPortugues;
            Action<string> ingles = MensagemIngles;
            Action<string> espanhol = MensagemEspanhol;

            Console.Write("Por favor, informe o seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("\nEscolha o idioma \nChoose your language \nElija su idioma:");
            Console.WriteLine("\n1 - Português");
            Console.WriteLine("2 - English");
            Console.WriteLine("3 - Español");

            Console.Write("\nDigite a opção de língua escolhida: ");
            string opcao = Console.ReadLine();

            Action<string> opcaoEscolhida;

            switch (opcao)
            {
                case "1":
                    opcaoEscolhida = portugues;
                    break;

                case "2":
                    opcaoEscolhida = ingles;
                    break;

                case "3":
                    opcaoEscolhida = espanhol;
                    break;

                default:
                    Console.WriteLine("\n[Opção inválida. O idioma padrão (Inglês) será utilizado.]");
                    opcaoEscolhida = ingles;
                    break;

            }

            opcaoEscolhida(nomeUsuario);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void MensagemPortugues(string nomeUsuario)
        {
            Console.WriteLine();
            Console.WriteLine($"Olá, {nomeUsuario}! Bem-vindo ao nosso sistema x.");
        }

        static void MensagemIngles(string nomeUsuario)
        {
            Console.WriteLine();
            Console.WriteLine($"Hello, {nomeUsuario}! Welcome to our system x.");
        }

        static void MensagemEspanhol(string nomeUsuario)
        {
            Console.WriteLine();
            Console.WriteLine($"¡Hola, {nomeUsuario}! Bienvenido a nuestro sistema x.");
        }
    
    }
}

