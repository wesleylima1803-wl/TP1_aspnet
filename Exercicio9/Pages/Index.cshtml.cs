using Exercicio8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio9.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Arroz", Preco = 7.50m },
                new Produto { Nome = "Feijão", Preco = 12.00m },
                new Produto { Nome = "Macarrão", Preco = 8.99m }
            };
        }
    }
}
