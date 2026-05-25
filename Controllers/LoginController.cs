using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec_MVC.Interfaces;
using Bibliotec_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec_MVC.Controllers
{

    public class LoginController : Controller
    {

        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string email, string senha)
        {
            Usuario? usuario = await _usuarioService.AutenticarUsuario(email, senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString("UsuarioId", usuario.Id.ToString());
                HttpContext.Session.SetString("Admin", usuario.TipoBib.ToString());
                
                return RedirectToAction("Index","Home");

               
            }

             ViewBag.Erro = "Usuario ou senha inválidos";
             return View("Index");

        }

    }
}