using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaInformacionTercol.Web.Models;

namespace SistemaInformacionTercol.Web.Controllers
{
    public class TblusuariosController : Controller
    {
        private readonly sigt2Context _context;

        public TblusuariosController(sigt2Context context)
        {
            _context = context;
        }

        // GET: Tblusuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tblusuarios.ToListAsync());
        }

        // GET: Tblusuarios/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblusuarios = await _context.Tblusuarios
                .FirstOrDefaultAsync(m => m.Idusuario == id);
            if (tblusuarios == null)
            {
                return NotFound();
            }

            return View(tblusuarios);
        }

        // GET: Tblusuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tblusuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idusuario,Idperfil,Strlogin,Strdescripcion,Password,Estado")] Tblusuarios tblusuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblusuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblusuarios);
        }

        // GET: Tblusuarios/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblusuarios = await _context.Tblusuarios.FindAsync(id);
            if (tblusuarios == null)
            {
                return NotFound();
            }
            return View(tblusuarios);
        }

        // POST: Tblusuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Idusuario,Idperfil,Strlogin,Strdescripcion,Password,Estado")] Tblusuarios tblusuarios)
        {
            if (id != tblusuarios.Idusuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblusuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblusuariosExists(tblusuarios.Idusuario))
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
            return View(tblusuarios);
        }

        // GET: Tblusuarios/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblusuarios = await _context.Tblusuarios
                .FirstOrDefaultAsync(m => m.Idusuario == id);
            if (tblusuarios == null)
            {
                return NotFound();
            }

            return View(tblusuarios);
        }

        // POST: Tblusuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var tblusuarios = await _context.Tblusuarios.FindAsync(id);
            _context.Tblusuarios.Remove(tblusuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblusuariosExists(byte id)
        {
            return _context.Tblusuarios.Any(e => e.Idusuario == id);
        }
    }
}
