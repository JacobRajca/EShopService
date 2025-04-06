using Eshop.Application;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly IValidationCard _validator;

        public CreditCardController(IValidationCard validator)
        {
            _validator = validator;
        }

        [HttpGet]
        public IActionResult Get(string cardNumber)
        {
            try
            {
                _validator.ValidateCardNumber(cardNumber);

                return Ok(new { cardProvider = _validator.GetCardType(cardNumber)});
            }
            catch (CardNumberTooShortException)
            {
                return BadRequest(new { error = "Numer karty jest za krótki." });
            }
            catch (CardNumberTooLongException)
            {
                return StatusCode(414, new { error = "Numer karty jest za długi." });
            }
            catch (CardNumberInvalidException)
            {
                return BadRequest(new { error = "Numer karty jest nieprawidłowy lub nie rozpoznano wydawcy." });
            }
        }
    }
}
