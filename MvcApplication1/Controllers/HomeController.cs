using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult CadastroAluno()
        {
            ModelAluno objAluno = new ModelAluno();

            return View(objAluno);
        }

        [HttpPost]
        public ActionResult ExibeDadosCadastroAluno(FormCollection form)
        {
            ViewBag.IdAluno = form["id_Aluno"];
            ViewBag.Nome = form["Nome_Aluno"];
            ViewBag.Email = form["Email_Aluno"];

            return View();
        }

        [HttpPost]
        public ActionResult ExibeDadosCadastroAlunoTipado(ModelAluno aluno)
        {
            return View(aluno);
        }

        public ActionResult Menu()
        {
            return PartialView();
        }
    }
}
