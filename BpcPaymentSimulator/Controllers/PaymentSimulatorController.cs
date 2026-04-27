namespace BpcPaymentSimulator.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PaymentSimulatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(string paymentMethod)
        {
            // TODO: Implement payment processing logic
            ViewBag.Message = $"Processing {paymentMethod}...";
            return View("Index");
        }
    }
}
