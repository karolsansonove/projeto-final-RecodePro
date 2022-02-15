using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Data;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Controllers
{
    public class LoginController : Controller
    {
        private ProjetoFinalDbContext _context;

        public LoginController(ProjetoFinalDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string errorMessage)

        {

            ViewBag.usuarioPadrao = "exemplo@patioba.br";
            ViewBag.ErrorMessage = errorMessage ?? string.Empty;

            return View();
        }

        public IActionResult Login(Cliente cliente)
        {
            if(_context.Cliente.Any(x => x.Email == cliente.Email && x.Senha == cliente.Senha))
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Index", "Login", new { errorMessage = "Email ou senha inválidos!" });
            }

        }
    }
}
