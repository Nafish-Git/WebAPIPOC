using System;

namespace WebApiTest.Cards
{
    public class GoldCard : ICards
    {
        public int Discount()
        {
            return 3000;
        }
    }
}
