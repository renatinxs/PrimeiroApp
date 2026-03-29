using Microsoft.AspNetCore.Mvc;
using PrimeiroApp.Models;
using PrimeiroApp.Repository.Contract;

namespace PrimeiroApp.Controllers 
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoController(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IActionResult Index()
        {
            return View(_enderecoRepository.ObterTodosEnderecos());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _enderecoRepository.Cadastrar(endereco);
                return RedirectToAction(nameof(Index));
            }
            return View(endereco);
        }
    } 
} 