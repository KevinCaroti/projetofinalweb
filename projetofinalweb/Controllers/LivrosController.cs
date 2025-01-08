using Microsoft.AspNetCore.Mvc;
using projetofinalweb.Models;
using System.Linq;
using projetofinalweb.Data;

namespace ProjetoFinalWeb.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Exibe todos os livros
        public IActionResult Index()
        {
            var livros = _context.Livros.ToList(); // Obtem dados da tabela Livros
            return View(livros); // Retorna os dados para uma View
        }
    }
}
