using Microsoft.AspNetCore.Mvc;
using PrimeiroApp.Models;
using PrimeiroApp.Repository.Contract;

namespace PrimeiroApp.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View(_usuarioRepository.ObterTodosUsuarios());
        }

        [HttpGet]
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioRepository.Excluir(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DetalhesUsuario(int id)
        {
            return View(_usuarioRepository.ObterUsuario(id));
        }

        [HttpGet]
        public IActionResult AtualizarUsuario(int id)
        {
            return View(_usuarioRepository.ObterUsuario(id));
        }

        [HttpGet]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DetalhesUsuario(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public IActionResult AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
                return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }
    }
}