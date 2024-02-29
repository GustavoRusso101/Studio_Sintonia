using Microsoft.AspNetCore.Mvc;
using Studio_Sintonia.Models;

namespace Studio_Sintonia.Controllers
{
    public class AutenticacaoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            // Lógica de autenticação
            if (AutenticarUsuario(usuario))
            {
                // Usuário autenticado com sucesso
                return RedirectToAction("Index", "Home"); // Redireciona para a página inicial após o login
            }
            else
            {
                // Exibir mensagem de erro na View
                ModelState.AddModelError("", "Credenciais inválidas");
                return View(usuario);
            }
        }

        private bool AutenticarUsuario(Usuario usuario)
        {
            // Lógica de autenticação (pode ser simulado para este exemplo)
            // Aqui você faria a verificação das credenciais no seu sistema
            // ...

            // Exemplo: credenciais válidas se o nome de usuário for "admin" e a senha for "admin123"
            return usuario.NomeUsuario == "admin" && usuario.Senha == "admin123";
        }
    }

}
