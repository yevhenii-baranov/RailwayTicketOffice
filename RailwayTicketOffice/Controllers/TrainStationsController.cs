using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RailwayTicketOffice.Database;
using RailwayTicketOffice.Entity;

namespace RailwayTicketOffice
{
    public class TrainStationsController : Controller
    {
        private readonly MySqlDbContext _context;

        public TrainStationsController(MySqlDbContext context)
        {
            _context = context;
        }

        // GET: TrainStations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stations.ToListAsync());
        }

        // GET: TrainStations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainStation = await _context.Stations
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trainStation == null)
            {
                return NotFound();
            }

            return View(trainStation);
        }

        // GET: TrainStations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainStations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,ID")] TrainStation trainStation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainStation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainStation);
        }

        // GET: TrainStations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainStation = await _context.Stations.FindAsync(id);
            if (trainStation == null)
            {
                return NotFound();
            }
            return View(trainStation);
        }

        // POST: TrainStations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,ID")] TrainStation trainStation)
        {
            if (id != trainStation.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainStation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainStationExists(trainStation.ID))
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
            return View(trainStation);
        }

        // GET: TrainStations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainStation = await _context.Stations
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trainStation == null)
            {
                return NotFound();
            }

            return View(trainStation);
        }

        // POST: TrainStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainStation = await _context.Stations.FindAsync(id);
            _context.Stations.Remove(trainStation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainStationExists(int id)
        {
            return _context.Stations.Any(e => e.ID == id);
        }
    }
}
