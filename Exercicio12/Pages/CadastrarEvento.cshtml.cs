using Exercicio12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio12  .Pages
{
    public class CadastrarEventoModel : PageModel
    {
        [BindProperty]
        public Evento NovoEvento { get; set; }

        public bool Sucesso { get; set; }

        public void OnGet()
        {
            Sucesso = false;
        }

        public void OnPost()
        {

            MonitoramentoDeEventos.RegistrarCriacaoConsole?.Invoke(NovoEvento);


            Sucesso = true;
        }
    }
}