using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaClinicas2.Dominio.Cadastros;
using SistemaClinicas2.Dominio.Cadastros.Servicos;
using SistemaClinicas2.UI.ViewModels;

namespace SistemaClinicas2.UI.Controllers
{
    public class EspecialidadeController : Controller
    {
        private IEspecialidadeServico EspecialidadeServico;

        public EspecialidadeController(IEspecialidadeServico EspecialidadeServico)
        {
            this.EspecialidadeServico = EspecialidadeServico;
        }

        public IActionResult Index()
        {
            var especialidadesViewModel =
                EspecialidadeServico.Listar()
                .Select(s => new EspecialidadeViewModel
                {
                    Id = s.Id,
                    Nome = s.Nome
                }).ToList();


            return View(especialidadesViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EspecialidadeViewModel e)
        {
            Especialidade objTemp = new Especialidade();
            objTemp.setNome(e.Nome);
            EspecialidadeServico.Incluir(objTemp);
            return RedirectToAction("index");
        }
    }
}