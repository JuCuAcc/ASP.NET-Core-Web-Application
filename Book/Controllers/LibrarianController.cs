using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;
using Book.Data;
using Book.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Book.Controllers
{
    public class LibrarianController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public LibrarianController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            this._context = context;
            this._webHost = webHost;
        }

        public IActionResult Index()
        {
            List<Librarian> librarians;
            librarians = _context.Librarians.ToList();
            return View(librarians);
        }

        public IActionResult Create()
        {
            Librarian librarian = new Librarian();
            librarian.Experiences.Add(new Experience() { ExperienceId = 1 });
            ViewBag.ExperienceId = new SelectList(_context.Experiences, "ExperienceId", "YearsWorked", librarian.TotalExperience); // ExperienceId
            return View(librarian);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Librarian librarian)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = GetUploadedFileName(librarian);
                librarian.PhotoUrl = uniqueFileName;
                _context.Add(librarian);
                _context.SaveChanges();

            }

            ViewBag.ExperienceId = new SelectList(_context.Experiences, "ExperienceId", "YearsWorked", librarian.TotalExperience);
            return RedirectToAction("Index");

        }


        public IActionResult Edit(int? id)
        {

            Librarian librarian =  _context.Librarians.Include(e => e.Experiences).Where(l => l.LibrarianId == id).FirstOrDefault();


            if (librarian == null)
            {
                return NotFound();
            }
            ViewBag.ExperienceId = new SelectList(_context.Experiences, "ExperienceId", "YearsWorked", librarian.TotalExperience); // ExperienceId
            return View(librarian);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Librarian librarian)
        {
            //Librarian oneLibrarian = await _context.Librarians.FindAsync(librarian.LibrarianId);

            //if (ModelState.IsValid)
            //{

            //    string uniqueFileName = GetUploadedFileName(librarian);
            //    librarian.PhotoUrl = uniqueFileName;

            //    _context.Update(librarian);
            //    //_context.SaveChanges();
            //    await _context.SaveChangesAsync();

            //    //_context.Entry(librarian).State = EntityState.Modified;
            //    //_context.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.ExperienceId = new SelectList(_context.Experiences, "ExperienceId", "YearsWorked", librarian.TotalExperience);
            ////ViewBag.ExperienceId = new SelectList(_context.Experiences, "ExperienceId", "YearsWorked", librarian.TotalExperience);
            ////return View(librarian);
            //return RedirectToAction("Index");


            try
            {

                string uniqueFileName = GetUploadedFileName(librarian);
                librarian.PhotoUrl = uniqueFileName;
                _context.Update(librarian);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View(librarian);
            }


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var librarian = await _context.Librarians.FirstOrDefaultAsync(m => m.LibrarianId == id);
            if (librarian == null)
            {
                return NotFound();
            }

            return View(librarian);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var librarian = await _context.Librarians.FindAsync(id);
            _context.Librarians.Remove(librarian);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var librarian = await _context.Librarians.FirstOrDefaultAsync(m => m.LibrarianId == id);
            if (librarian == null)
            {
                return NotFound();
            }

            return View(librarian);
        }


        private bool LibrarianExists(int id)
        {
            return _context.Librarians.Any(e => e.LibrarianId == id);
        }


        private string GetUploadedFileName(Librarian librarian)
        {
            string uniqueFileName = null;

            if (librarian.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "Uploads"); // Uploads/
                uniqueFileName = Guid.NewGuid().ToString() + "_" + librarian.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    librarian.ProfilePhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


    }

}