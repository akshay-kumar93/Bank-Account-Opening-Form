using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank_Account_Opening_Form.Models;
using System;

namespace BankAccountOpeningForm.Controllers
{
    public class AccountOpeningFormController : Controller
    {
        private readonly BankContext _context;

        public AccountOpeningFormController(BankContext context)
        {
            _context = context;
        }

        // GET: AccountOpeningForm
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccountOpeningForms.ToListAsync());
        }

        // GET: AccountOpeningForm/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountOpeningForm = await _context.AccountOpeningForms
                .FirstOrDefaultAsync(m => m.FormNumber == id);
            if (accountOpeningForm == null)
            {
                return NotFound();
            }

            return View(accountOpeningForm);
        }

        // GET: AccountOpeningForm/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountOpeningForm/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustTitle,CustFirstName,CustMiddleName,CustLastName,CustSex,CustDateOfBirth,CustAge,CustStdCode,CustTelephone,CustMobile,CustEmailId,CustStateCode,CustCityCode,CustBranchCode,CustAccountType,CustPreferredLanguage")] AccountOpeningForm accountOpeningForm)
        {
            if (ModelState.IsValid)
            {
                accountOpeningForm.FormFillingDate = DateTime.Now;
                accountOpeningForm.FormFillingTime = DateTime.Now.TimeOfDay;
                _context.Add(accountOpeningForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountOpeningForm);
        }

        // GET: AccountOpeningForm/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountOpeningForm = await _context.AccountOpeningForms.FindAsync(id);
            if (accountOpeningForm == null)
            {
                return NotFound();
            }
            return View(accountOpeningForm);
        }

        // POST: AccountOpeningForm/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormNumber,CustTitle,CustFirstName,CustMiddleName,CustLastName,CustSex,CustDateOfBirth,CustAge,CustStdCode,CustTelephone,CustMobile,CustEmailId,CustStateCode,CustCityCode,CustBranchCode,CustAccountType,CustPreferredLanguage")] AccountOpeningForm accountOpeningForm)
        {
            if (id != accountOpeningForm.FormNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountOpeningForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountOpeningFormExists(accountOpeningForm.FormNumber))
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
            return View(accountOpeningForm);
        }

        // GET: AccountOpeningForm/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountOpeningForm = await _context.AccountOpeningForms
                .FirstOrDefaultAsync(m => m.FormNumber == id);
            if (accountOpeningForm == null)
            {
                return NotFound();
            }

            return View(accountOpeningForm);
        }

        // POST: AccountOpeningForm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountOpeningForm = await _context.AccountOpeningForms.FindAsync(id);
            _context.AccountOpeningForms.Remove(accountOpeningForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountOpeningFormExists(int id)
        {
            return _context.AccountOpeningForms.Any(e => e.FormNumber == id);
        }

        // GET: AccountOpeningForm/Quit
        public IActionResult Quit()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
