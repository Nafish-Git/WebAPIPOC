using WebApiTest.Cards;

namespace WebApiTest
{
    public interface IBankCustomerBill {
        double GetBill(int billAmount, int discount);
    }
    public class BankCustomerBill : IBankCustomerBill
    {
        public double GetBill(int billAmount, int discount)
        {
            double finalBill;

            if (billAmount > 10000)
            {
                double gstAmount = (billAmount * 0.2);
                finalBill = ((gstAmount + billAmount) - discount);
            }
            else
            {
                double gstAmount = (billAmount * 0.2);
                finalBill = ((gstAmount + billAmount));
            }

            return finalBill;
        }
    }
}
