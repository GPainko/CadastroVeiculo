using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CadastroVeiculos.Models;
using CadastroVeiculos.Data;

namespace CadastroVeiculos.Pages.Veiculos
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Veiculo? Veiculo { get; set; }

        public IActionResult OnGet(string renavam)
        {
            Veiculo = VeiculoRepository.BuscarPorRenavam(renavam);
            if (Veiculo == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (Veiculo != null)
            {
                VeiculoRepository.Excluir(Veiculo.Renavam);
            }

            return RedirectToPage("Index");
        }
    }
}
