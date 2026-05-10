using System;

namespace Exercicio12.Models
{
    public class Evento
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }

    public static class MonitoramentoDeEventos
    {
        public static Action<Evento> RegistrarCriacaoConsole = (novoEvento) =>
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Novo evento cadastrado com sucesso!");
            Console.WriteLine($"Título: {novoEvento.Titulo}");
            Console.WriteLine($"Data: {novoEvento.Data:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Local: {novoEvento.Local}");
            Console.ResetColor();
        };
    }
}