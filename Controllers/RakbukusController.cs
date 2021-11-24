using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TokoBuku.Models;

namespace TokoBuku.Controllers
{
    public class RakbukusController : Controller
    {
        private readonly BukuContext _context;

        public RakbukusController(BukuContext context)
        {
            _context = context;
        }

        // GET: Rakbukus
        public async Task<IActionResult> Index()
        {
            return View(await _context.rakbuku.ToListAsync());
        }

        // GET: Rakbukus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rakbuku = await _context.rakbuku
                .FirstOrDefaultAsync(m => m.id_buku == id);
            if (rakbuku == null)
            {
                return NotFound();
            }

            return View(rakbuku);
        }

        // GET: Rakbukus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rakbukus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_buku,nama_buku,kategori_buku,harga,gambar_buku,penerbit_buku,diskon,jumlah_buku")] rakbuku rakbuku)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rakbuku);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rakbuku);
        }

        // GET: Rakbukus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rakbuku = await _context.rakbuku.FindAsync(id);
            if (rakbuku == null)
            {
                return NotFound();
            }
            return View(rakbuku);
        }

        // POST: Rakbukus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_buku,nama_buku,kategori_buku,harga,gambar_buku,penerbit_buku,diskon,jumlah_buku")] rakbuku rakbuku)
        {
            if (id != rakbuku.id_buku)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rakbuku);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!rakbukuExists(rakbuku.id_buku))
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
            return View(rakbuku);
        }

        // GET: Rakbukus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rakbuku = await _context.rakbuku
                .FirstOrDefaultAsync(m => m.id_buku == id);
            if (rakbuku == null)
            {
                return NotFound();
            }

            return View(rakbuku);
        }

        // POST: Rakbukus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rakbuku = await _context.rakbuku.FindAsync(id);
            _context.rakbuku.Remove(rakbuku);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool rakbukuExists(int id)
        {
            return _context.rakbuku.Any(e => e.id_buku == id);
        }
    }
}
