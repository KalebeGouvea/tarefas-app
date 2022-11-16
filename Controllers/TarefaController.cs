using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tarefas_app.Context;

namespace tarefas_app.Controllers
{
    public class TarefaController : Controller
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }
    }
}