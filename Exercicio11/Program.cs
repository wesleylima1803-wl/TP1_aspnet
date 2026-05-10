using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> delegateString = Concatenar;
            delegateString += Maiusculas;
            delegateString += RemoverEspacos;

            Console.Write("Digite o primeiro nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            string executarDelegateString = delegateString(nome, sobrenome);

            Console.WriteLine($"\nResultado antes dos métodos individuais: {executarDelegateString}");

            foreach (Func<string, string, string> metodo in delegateString.GetInvocationList())
            {
                string tipoDelegate = metodo(nome, sobrenome);
                Console.WriteLine($"\nO método '{metodo.Method.Name}' retornou: {tipoDelegate}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static string Concatenar(string a, string b)
        {
            return $"{a} {b}";
        }

        static string Maiusculas(string a, string b)
        {
            return $"{a} {b}".ToUpper();
        }

        static string RemoverEspacos(string a, string b)
        {
            return $"{a}{b}".Replace(" ", "");
        }
    }
}