using ActualOCDatabase.Data;
using ActualOCDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ActualOCDatabase.Controllers
{
    public class OriginalCharactersController : Controller
    {
        private readonly ActualOCDatabaseContext _context;

        public OriginalCharactersController(ActualOCDatabaseContext context)
        {
            _context = context;
        }

        // GET: OriginalCharacters
        public async Task<IActionResult> Index()
        {
            return View(await _context.OriginalCharacter.ToListAsync());
        }

        // GET: OriginalCharacters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalCharacter = await _context.OriginalCharacter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (originalCharacter == null)
            {
                return NotFound();
            }

            return View(originalCharacter);
        }

        // GET: OriginalCharacters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OriginalCharacters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,NickName,DateOfBirth")] OriginalCharacter originalCharacter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(originalCharacter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(originalCharacter);
        }

        // GET: OriginalCharacters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalCharacter = await _context.OriginalCharacter.FindAsync(id);
            if (originalCharacter == null)
            {
                return NotFound();
            }
            return View(originalCharacter);
        }

        // POST: OriginalCharacters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,NickName,DateOfBirth")] OriginalCharacter originalCharacter)
        {
            if (id != originalCharacter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(originalCharacter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OriginalCharacterExists(originalCharacter.Id))
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
            return View(originalCharacter);
        }

        // GET: OriginalCharacters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalCharacter = await _context.OriginalCharacter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (originalCharacter == null)
            {
                return NotFound();
            }

            return View(originalCharacter);
        }

        // POST: OriginalCharacters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var originalCharacter = await _context.OriginalCharacter.FindAsync(id);
            if (originalCharacter != null)
            {
                _context.OriginalCharacter.Remove(originalCharacter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OriginalCharacterExists(int id)
        {
            return _context.OriginalCharacter.Any(e => e.Id == id);
        }
    }
}
