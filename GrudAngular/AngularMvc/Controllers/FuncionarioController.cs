
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AngularMvc.EF;
using AngularMvc.Models;

namespace AngularMvc.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetFuncionario()
        {
            var context = new Context();
            List<Funcionario> listOfFuncionarios = context.Funcionario.ToList();
            return Json(listOfFuncionarios, JsonRequestBehavior.AllowGet);
        }
    }
}