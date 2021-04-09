﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PizzaKnight.Controllers
{
    public class PaymentInfoesController : Controller
    {
        private readonly Models._5510Context _context;

        public int CustomerName { get; private set; }

        public PaymentInfoesController(Models._5510Context context)
        {
            _context = context;
        }

        //GET: PaymentInfoes
        public async Task<IActionResult> Index()
        {
            var _5510Context = _context.PaymentInfo.Include(p => p.CustomerName);
            return View(await _5510Context.ToListAsync());
        }

        //GET: PaymentInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentInfo = await _context.PaymentInfo
                .Include(p => p.CustomerName)
                .FirstOrDefaultAsync(m => m.CustomerName.Equals(CustomerName));
            if (paymentInfo == null)
            {
                return NotFound();
            }

            return View(paymentInfo);
        }

        //GET: PaymentInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: PaymentInfoes/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerName,CardType,CardValue,CVV,ExpiryDate")] Models.PaymentInfo paymentInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentInfo);
                await _context.SaveChangesAsync();
                Response.Redirect(@"\Home\Delivery");

            }

            return View(paymentInfo);
        }

        // GET: PaymentInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentInfo = await _context.PaymentInfo.FindAsync(id);
            if (paymentInfo == null)
            {
                return NotFound();
            }
            //ViewData["Custid"] = new SelectList(_context.Customers, "Id", "Id", paymentInfo.CustomerName);
            return View(paymentInfo);
        }

        // POST: PaymentInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerName,Cardtype,Cardvalue,Cvv,Expirydate")] Models.PaymentInfo paymentInfo)
        {
            if (!CustomerName.Equals(paymentInfo.CustomerName))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentInfoExists(paymentInfo.CustomerName))
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

            return View(paymentInfo);
        }

        //GET: PaymentInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentInfo = await _context.PaymentInfo
                .Include(p => p.CustomerName)
                .FirstOrDefaultAsync(m => m.CustomerName.Equals(CustomerName));
            if (paymentInfo == null)
            {
                return NotFound();
            }

            return View(paymentInfo);
        }

        //POST: PaymentInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentInfo = await _context.PaymentInfo.FindAsync(id);
            _context.PaymentInfo.Remove(paymentInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentInfoExists(String CustomerName)
        {
            return _context.PaymentInfo.Any(e => e.CustomerName.Equals(CustomerName));
        }
    }
}
