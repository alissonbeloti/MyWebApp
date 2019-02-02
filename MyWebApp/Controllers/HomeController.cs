using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        public HomeController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
        public IActionResult Index()
        {
            return View(produtoRepository.Produtos());
        }

        public string Obter()
        {
            return "Teste3";
        }
    }
}