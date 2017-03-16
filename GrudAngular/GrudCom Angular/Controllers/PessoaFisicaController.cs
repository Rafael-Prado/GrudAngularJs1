
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using GrudComAngular.Models;
using GrudCom_Angular.Conexao;

namespace GrudCom_Angular.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private Context db = new Context();

        // GET: PessoaFisica
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllPessoaFisica()
        {
            var pessoaFisica = db.PessoaFisica.ToList();
            return Json(pessoaFisica, JsonRequestBehavior.AllowGet);
        }


        // GET: PessoaFisica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = db.PessoaFisica.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoaFisica/Create
        [HttpPost]
        public ActionResult Create(PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.PessoaFisica.Add(pessoaFisica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = db.PessoaFisica.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // POST: PessoaFisica/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PessoaFisicaId,Nome,Cpf,Rg")] PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaFisica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoaFisica);
        }

        // GET: PessoaFisica/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaFisica pessoaFisica = db.PessoaFisica.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // POST: PessoaFisica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PessoaFisica pessoaFisica = db.PessoaFisica.Find(id);
            db.PessoaFisica.Remove(pessoaFisica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
