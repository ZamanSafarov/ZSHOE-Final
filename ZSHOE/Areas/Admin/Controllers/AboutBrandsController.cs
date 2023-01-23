using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.Entities.ViewModels;

namespace ZSHOE.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutBrandsController : Controller
    {
        private readonly ZSHOEDbContext _context;

        public AboutBrandsController(ZSHOEDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AboutBrands
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutBrands.ToListAsync());
        }

        // GET: Admin/AboutBrands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutBrand = await _context.AboutBrands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutBrand == null)
            {
                return NotFound();
            }

            return View(aboutBrand);
        }

        // GET: Admin/AboutBrands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutBrands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Body,ImagePath,Id,CreatedDate,DeletedDate")] AboutBrand aboutBrand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutBrand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutBrand);
        }

        // GET: Admin/AboutBrands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutBrand = await _context.AboutBrands.FindAsync(id);
            if (aboutBrand == null)
            {
                return NotFound();
            }
            return View(aboutBrand);
        }

        // POST: Admin/AboutBrands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Body,ImagePath,Id,CreatedDate,DeletedDate")] AboutBrand aboutBrand)
        {
            if (id != aboutBrand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutBrand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutBrandExists(aboutBrand.Id))
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
            return View(aboutBrand);
        }

        // GET: Admin/AboutBrands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutBrand = await _context.AboutBrands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutBrand == null)
            {
                return NotFound();
            }

            return View(aboutBrand);
        }

        // POST: Admin/AboutBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutBrand = await _context.AboutBrands.FindAsync(id);
            _context.AboutBrands.Remove(aboutBrand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutBrandExists(int id)
        {
            return _context.AboutBrands.Any(e => e.Id == id);
        }


    }
}
