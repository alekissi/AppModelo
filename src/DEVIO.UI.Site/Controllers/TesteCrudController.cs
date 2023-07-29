using DEVIO.UI.Site.Data;
using DEVIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEVIO.UI.Site.Controllers
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
                Nome = "Eduardo",
                DataNascimento = DateTime.Now,
                Email = "eduardo@pires.com"
            };

            _contexto.alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.alunos.Find(aluno.Id);

            var aluno3 = _contexto.alunos.FirstOrDefault(a => a.Email == "eduardo@pires.com");

            var aluno4 = _contexto.alunos.Where(a => a.Nome == "Eduardo");

            aluno.Nome = "João";
            _contexto.alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}
