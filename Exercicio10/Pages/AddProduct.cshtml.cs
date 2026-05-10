using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio10.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }
        [BindProperty]
        public decimal Preco { get; set; }

        public bool FormularioEnviado { get; set; }

        public void OnGet()
        {
            FormularioEnviado = false;
        }

        public void OnPost()
        {
            FormularioEnviado = true;
        }
    }
}