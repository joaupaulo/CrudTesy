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
    public class HabilidadesController : Controller
    {
        private readonly CadastroContext _context;

        public HabilidadesController(CadastroContext context)
        {
            _context = context;
        }

        // GET: Habilidades
        public async Task<IActionResult> Index()
        {
            var cadastroContext = _context.Habilidades.Include(h => h.InfoProgramador);
            return View(await cadastroContext.ToListAsync());
        }

        // GET: Habilidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidades = await _context.Habilidades
                .Include(h => h.InfoProgramador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidades == null)
            {
                return NotFound();
            }

            return View(habilidades);
        }

        // GET: Habilidades/Create
        public IActionResult Create()
        {
            ViewData["InfoProgramadorId"] = new SelectList(_context.InfoProgramador, "Id", "Estado");
            return View();
        }

        // POST: Habilidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InfoProgramadorId,Ionic,ReactJS,ReactNative,Android,Flutter,Swift,Ios,Html,Css,Bootstrap,Jquery,AngularJs1,Angular,Java,Python,AspMvc,AspWebForm,C,Csharp,NodeJS,ExpressNode,Cake,Djanto,Majento,Php,Vue,Ruby,MySqlServer,MySql,Salesforce,Photoshop,Ilustrator,Seo,Laravel,Outros")] Habilidades habilidades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habilidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InfoProgramadorId"] = new SelectList(_context.InfoProgramador, "Id", "Estado", habilidades.InfoProgramadorId);
            return View(habilidades);
        }

        // GET: Habilidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidades = await _context.Habilidades.FindAsync(id);
            if (habilidades == null)
            {
                return NotFound();
            }
            ViewData["InfoProgramadorId"] = new SelectList(_context.InfoProgramador, "Id", "Estado", habilidades.InfoProgramadorId);
            return View(habilidades);
        }

        // POST: Habilidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InfoProgramadorId,Ionic,ReactJS,ReactNative,Android,Flutter,Swift,Ios,Html,Css,Bootstrap,Jquery,AngularJs1,Angular,Java,Python,AspMvc,AspWebForm,C,Csharp,NodeJS,ExpressNode,Cake,Djanto,Majento,Php,Vue,Ruby,MySqlServer,MySql,Salesforce,Photoshop,Ilustrator,Seo,Laravel,Outros")] Habilidades habilidades)
        {
            if (id != habilidades.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habilidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabilidadesExists(habilidades.Id))
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
            ViewData["InfoProgramadorId"] = new SelectList(_context.InfoProgramador, "Id", "Estado", habilidades.InfoProgramadorId);
            return View(habilidades);
        }

        // GET: Habilidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habilidades = await _context.Habilidades
                .Include(h => h.InfoProgramador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habilidades == null)
            {
                return NotFound();
            }

            return View(habilidades);
        }

        // POST: Habilidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var habilidades = await _context.Habilidades.FindAsync(id);
            _context.Habilidades.Remove(habilidades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabilidadesExists(int id)
        {
            return _context.Habilidades.Any(e => e.Id == id);
        }
    }
}
