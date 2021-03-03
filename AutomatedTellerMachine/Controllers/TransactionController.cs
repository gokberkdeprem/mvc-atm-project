using AutomatedTellerMachine.Models;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class TransactionController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transaction/Deposit
        public ActionResult Deposit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(transaction);
                db.SaveChanges();
            return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}