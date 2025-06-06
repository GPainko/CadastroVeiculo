using CadastroVeiculos.Data;
using CadastroVeiculos.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroVeiculos.Pages.Veiculos
{
    public class IndexModel : PageModel
    {
        public List<Veiculo> Veiculos { get; set; } = new();

        public void OnGet()
        {
            Veiculos = VeiculoRepository.Listar();
        }
    }
}
