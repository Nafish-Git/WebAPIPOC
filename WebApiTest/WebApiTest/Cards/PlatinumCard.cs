using System.IO;
using System.Reflection;

namespace WebApiTest.Cards
{
    public class PlatinumCard : ICards
    {
        public int Discount()
        {
            return 4000;
        }
    }
}
