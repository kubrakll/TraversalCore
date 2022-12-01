using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous] //Altında ve üstünde bulunan tüm kodları onları geçerli kurarlardan muhaf ediyo
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
