using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Cards;

namespace WebApiTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DimondCardController : ControllerBase
    {
        IBankCustomerBill _bankCustomerBill;
        ICards _card;


        public DimondCardController(IBankCustomerBill bankCustomerBill)
        {
            _bankCustomerBill = bankCustomerBill;
        }

        [HttpGet(Name = "GetDimondDiscount")]
        public double GetDiscount(int bill)
        {
            try
            {
                _card = CardFactory.CreateCardTypeObj(CardType.DIMOND);
                return _bankCustomerBill.GetBill(bill, _card.Discount());
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
