﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleTracker.Models;

namespace VehicleTracker.Controllers
{
    public class TiresController : Controller
    {
        private readonly VehicleTrackerContext _context;

        public TiresController(VehicleTrackerContext context)
        {
            _context = context;
        }

        // GET: Tires
        public async Task<IActionResult> Index(int id)
        {
            return View(await _context.Tire.Where(m=>m.VehicleID == id).ToListAsync());
        }

        // GET: Tires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tire == null)
            {
                return NotFound();
            }

            return View(tire);
        }

        // GET: Tires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID")] Tire tire)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tire);
        }

        // GET: Tires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire.FindAsync(id);
            if (tire == null)
            {
                return NotFound();
            }
            
            return View(tire);
        }

        // POST: Tires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TireCondition,Location,VehicleID")] Tire tire)
        {
            if (id != tire.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TireExists(tire.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index),new { id = tire.VehicleID });
            }
            return View(tire);
        }

        // GET: Tires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tire == null)
            {
                return NotFound();
            }

            return View(tire);
        }

        // POST: Tires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tire = await _context.Tire.FindAsync(id);
            _context.Tire.Remove(tire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TireExists(int id)
        {
            return _context.Tire.Any(e => e.ID == id);
        }
    }
}
