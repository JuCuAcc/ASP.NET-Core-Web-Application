using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;
using Book.Data;
using Book.Models;
using static Book.Models.Helper;

namespace Book.Controllers
{
    public class FineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FineController(ApplicationDbContext context)
        {
            this._context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Fines.ToListAsync());
        }



        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Fine());
            else
            {
                var fine = await _context.Fines.FindAsync(id);
                if (fine == null)
                {
                    return NotFound();
                }
                return View(fine);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, Fine fine)
        {
            if (ModelState.IsValid)
            {
                //Insert
                if (id == 0)
                {
                    fine.Date = DateTime.Now;
                    _context.Add(fine);
                    await _context.SaveChangesAsync();

                }
                //Update
                else
                {
                    try
                    {
                        _context.Update(fine);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FineExists(fine.FineId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Fines.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", fine) });
        }



        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fine = await _context.Fines.FirstOrDefaultAsync(m => m.FineId == id);
            if (fine == null)
            {
                return NotFound();
            }

            return View(fine);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fine = await _context.Fines.FirstOrDefaultAsync(m => m.FineId == id);

            if (fine == null)
            {
                return NotFound();
            }

            return View(fine);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fine = await _context.Fines.FindAsync(id);
            _context.Fines.Remove(fine);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Fines.ToList()) });
        }

        private bool FineExists(int id)
        {
            return _context.Fines.Any(e => e.FineId == id);
        }
    }
}
