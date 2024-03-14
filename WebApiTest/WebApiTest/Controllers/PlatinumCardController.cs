using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Cards;

namespace WebApiTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlatinumCardController : ControllerBase
    {
        IBankCustomerBill _bankCustomerBill;
        ICards _card;


        public PlatinumCardController(IBankCustomerBill bankCustomerBill)
        {
            _bankCustomerBill = bankCustomerBill;
        }

        [HttpGet(Name = "GetPlatinumDiscount")]
        public double GetDiscount(int bill)
        {
            try
            {
                _card = CardFactory.CreateCardTypeObj(CardType.PLATINUM);
                return _bankCustomerBill.GetBill(bill, _card.Discount());
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
