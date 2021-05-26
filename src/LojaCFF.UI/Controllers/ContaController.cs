using LojaCFF.Data.EF.Repositories;
using LojaCFF.Domain.Helpers;
using LojaCFF.Domain.Interfaces.Repositories;
using LojaCFF.UI.ViewModel.Login;
using System.Web.Mvc;
using System.Web.Security;

namespace LojaCFF.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly IUsuarioRepository _repUsuario = new UsuarioRepositoryEF();

        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            var login = new LoginViewModel { ReturnURL = ReturnUrl };

            return View(login);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            var user = _repUsuario.Get(login.Email);

            if (user == null)
                ModelState.AddModelError("Email", "Email não encontrado.");
            else
            {
                if (user.Senha != login.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha errada.");
            }

            if (ModelState.IsValid)
            {
                //Autenticar
                FormsAuthentication.SetAuthCookie(login.Email, login.PermanecerLogado);

                // Segura url vazia e url imbutida (somente redireciona para urls do sistema)
                if (!string.IsNullOrEmpty(login.ReturnURL) && Url.IsLocalUrl(login.ReturnURL))
                {
                    return Redirect(login.ReturnURL);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(login);
        }

        [HttpGet]
        public ActionResult LogOut(string ReturnUrl)
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            _repUsuario.Dispose();
        }
    }
}