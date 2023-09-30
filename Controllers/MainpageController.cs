using Microsoft.AspNetCore.Mvc;

namespace Mainpage.Controllers{
    public class Mainpage : Controller{
        [HttpGet]
        [Route("")]
        public ViewResult index(){
            return View();
        }
    }
}