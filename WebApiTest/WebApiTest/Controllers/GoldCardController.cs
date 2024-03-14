using Microsoft.AspNetCore.Mvc;
using WebApiTest.Cards;


namespace WebApiTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoldCardController : ControllerBase
    {

        IBankCustomerBill _bankCustomerBill;
        ICards _card;


        public GoldCardController(IBankCustomerBill bankCustomerBill)
        {
            _bankCustomerBill = bankCustomerBill;
        }

        [HttpGet(Name = "GetGoldDiscount")]
        public double GetDiscount(int bill)
        {
            try
            {
                _card = CardFactory.CreateCardTypeObj(CardType.GOLD);
                return _bankCustomerBill.GetBill(bill, _card.Discount());
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
