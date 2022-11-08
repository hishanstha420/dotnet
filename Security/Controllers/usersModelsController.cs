using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Security.Data;

namespace Security.Controllers
{
    public class usersModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public usersModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: usersModels
        public async Task<IActionResult> Index()
        {
              return _context.usersModel != null ? 
                          View(await _context.usersModel.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.usersModel'  is null.");
        }

        // GET: usersModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.usersModel == null)
            {
                return NotFound();
            }

            var usersModel = await _context.usersModel
                .FirstOrDefaultAsync(m => m.id == id);
            if (usersModel == null)
            {
                return NotFound();
            }

            return View(usersModel);
        }

        // GET: usersModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: usersModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Username,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] usersModel usersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersModel);
        }

        // GET: usersModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.usersModel == null)
            {
                return NotFound();
            }

            var usersModel = await _context.usersModel.FindAsync(id);
            if (usersModel == null)
            {
                return NotFound();
            }
            return View(usersModel);
        }

        // POST: usersModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,Username,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] usersModel usersModel)
        {
            if (id != usersModel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usersModelExists(usersModel.id))
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
            return View(usersModel);
        }

        // GET: usersModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.usersModel == null)
            {
                return NotFound();
            }

            var usersModel = await _context.usersModel
                .FirstOrDefaultAsync(m => m.id == id);
            if (usersModel == null)
            {
                return NotFound();
            }

            return View(usersModel);
        }

        // POST: usersModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.usersModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.usersModel'  is null.");
            }
            var usersModel = await _context.usersModel.FindAsync(id);
            if (usersModel != null)
            {
                _context.usersModel.Remove(usersModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool usersModelExists(string id)
        {
          return (_context.usersModel?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
