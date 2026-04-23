using Microsoft.AspNetCore.Mvc;

namespace SunboxPaymentSimulator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentSimulatorController : ControllerBase
    {
        [HttpPost("payPal")] // PayPal payment method
        public IActionResult PayPal(PaymentModel model)
        {
            // PayPal payment processing logic
            return Ok();
        }
        
        [HttpPost("creditCard")] // Credit Card payment method
        public IActionResult CreditCard(PaymentModel model)
        {
            // Credit Card payment processing logic
            return Ok();
        }
        
        // Additional payment methods can be added here
    }
}