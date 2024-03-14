using Microsoft.AspNetCore.Builder;
using WebApiTest;
using Moq;
using WebApiTest.Cards;

namespace WebAPIPOCTest
{
    public class GoldCardTest
    {
        private readonly ICards _card;

        public GoldCardTest()
        {
            _card = CardFactory.CreateCardTypeObj(CardType.GOLD);
        }

        [Fact]
        public void TestToVerifyGoldCardCalculation_For_10000()
        {
            // Arrange
            var disc = _card.Discount();
            //Act
            var subject = new BankCustomerBill();

            var result = subject.GetBill(10000, disc);

            //Assert
            Assert.True(result > 10000, "Discount is not applied on 10000");
        }

        [Fact]
        public void TestToVerifyGoldCardCalculation_Grt_than_10000()
        {
            // Arrange
            var disc = _card.Discount();
            //Act
            var subject = new BankCustomerBill();

            var result = subject.GetBill(15000, disc);

            //Assert
            Assert.True(result > 10000, "Discount is applied on bill > 10000");
        }
    }
}