

namespace ShoppingCostAnalyser.Models
{
    public class ShoppingCostAnalyser
    {
       
        private readonly IWallet wallet;

        public ShoppingCostAnalyser(IWallet wallet)
        {
            this.wallet = wallet;
        }
      
        public double CalculateTotalExpense(double expense1, double expense2)
        {
            return expense1 + expense2;
        }
      
        public double GetAmountRemainingForShopping(double totalExpense)
        {
            //return initialAmount - totalExpense;
            return this.wallet.CalculateAmountRemainingForShopping(totalExpense);
        }
    }
}