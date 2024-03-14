namespace WebApiTest.Cards
{
    public class CardFactory
    {
        public static ICards CreateCardTypeObj(CardType loggerType)
        { 
            switch (loggerType)
            {
                case CardType.PLATINUM:
                    return new PlatinumCard();
                case CardType.DIMOND:
                    return new DimondCard();
                case CardType.GOLD:
                    default:
                        return new GoldCard();

            }
        }
    }
}
