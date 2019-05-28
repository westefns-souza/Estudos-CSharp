using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Westefns.UI.Site.Data;
using Westefns.UI.Site.Models;

namespace Westefns.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Westefns",
                DataNascimento = DateTime.Now,
                Email = "westefns@outlook.com.br"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find();
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "westefns@outlook.com.br");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Westefns");

            aluno.Nome = "Westefns Damião";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}