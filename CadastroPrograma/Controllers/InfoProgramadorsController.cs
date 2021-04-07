using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroPrograma.Contexto;
using CadastroPrograma.Models;

namespace CadastroPrograma.Controllers
{
    public class InfoProgramadorsController : Controller
    {
        private readonly CadastroContext _context;

        public InfoProgramadorsController(CadastroContext context)
        {
            _context = context;
        }

        // GET: InfoProgramadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfoProgramador.ToListAsync());
        }

        // GET: InfoProgramadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoProgramador = await _context.InfoProgramador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoProgramador == null)
            {
                return NotFound();
            }

            return View(infoProgramador);
        }

        // GET: InfoProgramadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoProgramadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,NumeroWhats,Linkedin,Local,Estado,Portifolio,HorarioManha,HorarioNoite,HorarioMadrugada,HorarioTarde,HorarioComercial,Salario")] InfoProgramador infoProgramador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoProgramador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoProgramador);
        }

        // GET: InfoProgramadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoProgramador = await _context.InfoProgramador.FindAsync(id);
            if (infoProgramador == null)
            {
                return NotFound();
            }
            return View(infoProgramador);
        }

        // POST: InfoProgramadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,NumeroWhats,Linkedin,Local,Estado,Portifolio,HorarioManha,HorarioNoite,HorarioMadrugada,HorarioTarde,HorarioComercial,Salario")] InfoProgramador infoProgramador)
        {
            if (id != infoProgramador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoProgramador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoProgramadorExists(infoProgramador.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(infoProgramador);
        }

        // GET: InfoProgramadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoProgramador = await _context.InfoProgramador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoProgramador == null)
            {
                return NotFound();
            }

            return View(infoProgramador);
        }

        // POST: InfoProgramadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoProgramador = await _context.InfoProgramador.FindAsync(id);
            _context.InfoProgramador.Remove(infoProgramador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoProgramadorExists(int id)
        {
            return _context.InfoProgramador.Any(e => e.Id == id);
        }
    }
}
