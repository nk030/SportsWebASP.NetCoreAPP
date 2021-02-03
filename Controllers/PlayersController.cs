using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsWebASP.NetCoreAPP.Data;
using SportsWebASP.NetCoreAPP.Models;

namespace SportsWebASP.NetCoreAPP.Views.Players
{
    public class PlayersController : Controller
    {
        private readonly SportsWebASPNetCoreAPPContext _context;

        public PlayersController(SportsWebASPNetCoreAPPContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            var sportsWebASPNetCoreAPPContext = _context.Player.Include(p => p.DivisionObj).Include(p => p.SportObj).Include(p => p.TeamObj);
            return View(await sportsWebASPNetCoreAPPContext.ToListAsync());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .Include(p => p.DivisionObj)
                .Include(p => p.SportObj)
                .Include(p => p.TeamObj)
                .FirstOrDefaultAsync(m => m.PlayerId == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "DivisionId");
            ViewData["SportId"] = new SelectList(_context.Sport, "SportId", "SportId");
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "TeamId");
            return View();
        }

        // POST: Players/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerId,Name,Postition,TeamId,DivisionId,SportId")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "DivisionId", player.DivisionId);
            ViewData["SportId"] = new SelectList(_context.Sport, "SportId", "SportId", player.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "TeamId", player.TeamId);
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "DivisionId", player.DivisionId);
            ViewData["SportId"] = new SelectList(_context.Sport, "SportId", "SportId", player.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "TeamId", player.TeamId);
            return View(player);
        }

        // POST: Players/Edit/5
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlayerId,Name,Postition,TeamId,DivisionId,SportId")] Player player)
        {
            if (id != player.PlayerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.PlayerId))
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
            ViewData["DivisionId"] = new SelectList(_context.Division, "DivisionId", "DivisionId", player.DivisionId);
            ViewData["SportId"] = new SelectList(_context.Sport, "SportId", "SportId", player.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "TeamId", player.TeamId);
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .Include(p => p.DivisionObj)
                .Include(p => p.SportObj)
                .Include(p => p.TeamObj)
                .FirstOrDefaultAsync(m => m.PlayerId == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await _context.Player.FindAsync(id);
            _context.Player.Remove(player);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.PlayerId == id);
        }
    }
}
