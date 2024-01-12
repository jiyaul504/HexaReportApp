using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HexaReportApp.Models;
using System.Composition;
using Microsoft.AspNetCore.Authorization;

namespace HexaReportApp.Controllers
{

    public class MonthReportsController : Controller
    {
        private readonly CtimeContext _context;

        public MonthReportsController(CtimeContext context)
        {
            _context = context;
        }

        // GET: MonthReports
        public async Task<IActionResult> Index()
        {
            List<MonthlyReportDisplay> data = new List<MonthlyReportDisplay>();
            var totalPresentCount = 0;
            var totalWOCount = 0;
            var totalHLCount = 0;
            var totalLVCount = 0;
            var totalAbsent = 0;
            TimeSpan totalOT = new TimeSpan(0);
            TimeSpan totalOTPlusWork = new TimeSpan(0);
            List<string> addedReports = new List<string>();
            var summaries = new List<MonthlyReportDisplaySummary>();

            var reports = await _context.MonthReports.OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
            foreach (var report in reports)
            {  // Get Reports related to specific Employee

                if (addedReports.Contains(report.Empcode) == false)
                {
                    var employee = await _context.EmpMasts.Where(x => x.Empcode == report.Empcode).FirstOrDefaultAsync();
                    var employeReports = reports.Where(x => x.Empcode == employee.Empcode);

                    totalPresentCount = employeReports.Where(x => x.Status == "P").Count();
                    totalWOCount = employeReports.Where(x => x.Status == "WO").Count();
                    totalHLCount = employeReports.Where(x => x.Status == "HL").Count();
                    totalLVCount = employeReports.Where(x => x.Status == "LV").Count();
                    totalAbsent = employeReports.Where(x => x.Status == "A").Count();

                    var summary = new MonthlyReportDisplaySummary();
                    // Add other Details 
                    summary.totalPresentCount = totalPresentCount;
                    summary.totalWOCount = totalWOCount;
                    summary.totalHLCount = totalHLCount;
                    summary.totalLVCount = totalLVCount;
                    summary.totalAbsent = totalAbsent;
                    summary.Empcode = report.Empcode;
                    summaries.Add(summary);
                    foreach (var employeeReport in employeReports)
                    {
                        var tot = TimeSpan.Parse(employeeReport.OverTime);
                        totalOT += tot;
                        summary.totalOT = totalOT.ToString();
                        summary.totalOTPlusWork = totalOTPlusWork.ToString();

                        var totppw = TimeSpan.Parse(employeeReport.OverTime) + TimeSpan.Parse(employeeReport.WorkTime);
                        totalOTPlusWork += totppw;

                        var newReport = new MonthlyReportDisplay();
                        newReport.Employee = employee;
                        // Add Reports
                        newReport.Report = employeeReport;
                        data.Add(newReport);
                    }
                    addedReports.Add(report.Empcode);
                }
            }


            ViewBag.summaries = summaries;
            return _context.MonthReports != null ?
                          View(data) :
                          Problem("Entity set 'CtimeContext.MonthReports'  is null.");
        }

        [HttpPost]
        public async Task<IActionResult> Index(MonthlyReportSearchModel searchItems)
        {
            var totalPresentCount = 0;
            var totalWOCount = 0;
            var totalHLCount = 0;
            var totalLVCount = 0;
            var totalAbsent = 0;
            TimeSpan totalOT = new TimeSpan(0);
            TimeSpan totalOTPlusWork = new TimeSpan(0);
            List<string> addedReports = new List<string>();
            var reports = new List<MonthReport>();
            var summaries = new List<MonthlyReportDisplaySummary>();

            List<MonthlyReportDisplay> data = new List<MonthlyReportDisplay>();


            // Return Search Results if the no Search Parameter Provided & Month & Year is Provided
            if (string.IsNullOrEmpty(searchItems.Search))
            {
                if (searchItems.Month == null && searchItems.Year == null)
                {
                    var currentMonth = DateTime.Now.ToString("MMMM");
                    var currentYear = DateTime.Now.Year.ToString();
                    reports = await _context.MonthReports.Where(x => x.MonthName == currentMonth && x.Year == currentYear).OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
                }
                else
                {
                    reports = await _context.MonthReports.Where(x => x.MonthName == searchItems.Month && x.Year == searchItems.Year).OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
                }
            }
            else
            {
                var searchEmployee = await _context.EmpMasts.Where(x => x.Empcode == searchItems.Search || x.Name == searchItems.Search || x.DeptName == searchItems.Search || x.CompName == searchItems.Search).FirstOrDefaultAsync();

                // If Employee is found get Results
                if (searchEmployee != null)
                {
                    if (searchItems.Month == null && searchItems.Year == null)
                    {
                        var currentMonth = DateTime.Now.ToString("MMMM");
                        var currentYear = DateTime.Now.Year.ToString();
                        reports = await _context.MonthReports.Where(x => x.Empcode == searchEmployee.Empcode && x.MonthName == currentMonth && x.Year == currentYear).OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
                    }
                    else
                    {
                        reports = await _context.MonthReports.Where(x => x.Empcode == searchEmployee.Empcode && x.MonthName == searchItems.Month && x.Year == searchItems.Year).OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
                    }
                }
                // If Employee is not found search by Month & Year
                else
                {

                    reports = await _context.MonthReports.Where(x => x.MonthName == searchItems.Month && x.Year == searchItems.Year).OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();

                }
            }
            // Search by Empcode, DeptName, or Campname


            foreach (var report in reports)
            {  // Get Reports related to specific Employee

                if (addedReports.Contains(report.Empcode) == false)
                {
                    var employee = await _context.EmpMasts.Where(x => x.Empcode == report.Empcode).FirstOrDefaultAsync();
                    var employeReports = reports.Where(x => x.Empcode == employee.Empcode);

                    totalPresentCount = employeReports.Where(x => x.Status == "P").Count();
                    totalWOCount = employeReports.Where(x => x.Status == "WO").Count();
                    totalHLCount = employeReports.Where(x => x.Status == "HL").Count();
                    totalLVCount = employeReports.Where(x => x.Status == "LV").Count();
                    totalAbsent = employeReports.Where(x => x.Status == "A").Count();

                    var summary = new MonthlyReportDisplaySummary();
                    // Add other Details 
                    summary.totalPresentCount = totalPresentCount;
                    summary.totalWOCount = totalWOCount;
                    summary.totalHLCount = totalHLCount;
                    summary.totalLVCount = totalLVCount;
                    summary.totalAbsent = totalAbsent;
                    summary.Empcode = report.Empcode;
                    summaries.Add(summary);
                    foreach (var employeeReport in employeReports)
                    {
                        var tot = TimeSpan.Parse(employeeReport.OverTime);
                        totalOT += tot;
                        summary.totalOT = totalOT.ToString();
                        summary.totalOTPlusWork = totalOTPlusWork.ToString();

                        var totppw = TimeSpan.Parse(employeeReport.OverTime) + TimeSpan.Parse(employeeReport.WorkTime);
                        totalOTPlusWork += totppw;

                        var newReport = new MonthlyReportDisplay();
                        newReport.Employee = employee;
                        // Add Reports
                        newReport.Report = employeeReport;
                        data.Add(newReport);
                    }
                    addedReports.Add(report.Empcode);
                }
            }

            ViewBag.summaries = summaries;
            return _context.MonthReports != null ?
                        View(data) :
                        Problem("Entity set 'CtimeContext.MonthReports'  is null.");
        }



        public async Task<JsonResult> GetMonthlyReport()
        {
            var report = await _context.MonthReports.OrderBy(x => x.Empcode).ThenBy(x => x.Date).ToListAsync();
            return new JsonResult(report);
        }


        // GET: MonthReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MonthReports == null)
            {
                return NotFound();
            }

            var monthReport = await _context.MonthReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monthReport == null)
            {
                return NotFound();
            }

            return View(monthReport);
        }

        // GET: MonthReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MonthReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Empcode,Date,Shift,Woff1,Woff2,MonthName,Year,TotalWork,TotalPresent,TotalAbsent,Intime,Outtime,WorkTime,OverTime,BreakTime,Status,Day,TotalOverTime,DateString,Out1,In2,Out2,In3,Out3,In4,Out4,In5,Out5,In6,Out6,In7,Out7,In8,Remark1,Remark2,ErlIn,ErlOut,LateIn,Ot,Ei,Eo,Lt,Otm,Lin,Lout,Lesswrk,Wo")] MonthReport monthReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monthReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monthReport);
        }

        // GET: MonthReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MonthReports == null)
            {
                return NotFound();
            }

            var monthReport = await _context.MonthReports.FindAsync(id);
            if (monthReport == null)
            {
                return NotFound();
            }
            return View(monthReport);
        }

        // POST: MonthReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Empcode,Date,Shift,Woff1,Woff2,MonthName,Year,TotalWork,TotalPresent,TotalAbsent,Intime,Outtime,WorkTime,OverTime,BreakTime,Status,Day,TotalOverTime,DateString,Out1,In2,Out2,In3,Out3,In4,Out4,In5,Out5,In6,Out6,In7,Out7,In8,Remark1,Remark2,ErlIn,ErlOut,LateIn,Ot,Ei,Eo,Lt,Otm,Lin,Lout,Lesswrk,Wo")] MonthReport monthReport)
        {
            if (id != monthReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monthReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonthReportExists(monthReport.Id))
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
            return View(monthReport);
        }

        // GET: MonthReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MonthReports == null)
            {
                return NotFound();
            }

            var monthReport = await _context.MonthReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monthReport == null)
            {
                return NotFound();
            }

            return View(monthReport);
        }

        // POST: MonthReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MonthReports == null)
            {
                return Problem("Entity set 'CtimeContext.MonthReports'  is null.");
            }
            var monthReport = await _context.MonthReports.FindAsync(id);
            if (monthReport != null)
            {
                _context.MonthReports.Remove(monthReport);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonthReportExists(int id)
        {
            return (_context.MonthReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
