using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.DataBaseContexts;

namespace TaskmanagementApi.Controllers
{
    public class CompanyServicesController : Controller
    {
        private readonly CompanyServicesDbContext _context;

        public CompanyServicesController(CompanyServicesDbContext context)
        {
            _context = context;
        }

        // GET: CompanyServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListofCompanyServices.ToListAsync());
        }

        // GET: CompanyServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyServices = await _context.ListofCompanyServices
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (companyServices == null)
            {
                return NotFound();
            }

            return View(companyServices);
        }

        // GET: CompanyServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ServiceName,ServiceStatus,TeamId")] CompanyServices companyServices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyServices);
        }

        // GET: CompanyServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyServices = await _context.ListofCompanyServices.FindAsync(id);
            if (companyServices == null)
            {
                return NotFound();
            }
            return View(companyServices);
        }

        // POST: CompanyServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceId,ServiceName,ServiceStatus,TeamId")] CompanyServices companyServices)
        {
            if (id != companyServices.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyServicesExists(companyServices.ServiceId))
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
            return View(companyServices);
        }

        // GET: CompanyServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyServices = await _context.ListofCompanyServices
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (companyServices == null)
            {
                return NotFound();
            }

            return View(companyServices);
        }

        // POST: CompanyServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyServices = await _context.ListofCompanyServices.FindAsync(id);
            if (companyServices != null)
            {
                _context.ListofCompanyServices.Remove(companyServices);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyServicesExists(int id)
        {
            return _context.ListofCompanyServices.Any(e => e.ServiceId == id);
        }
    }
}
