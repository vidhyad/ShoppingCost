

namespace ShoppingCostAnalyser.Models
{
    /// <summary>
    /// The wallet.
    /// </summary>
    public class Wallet : IWallet
    {
        /// <summary>
        /// The amout.
        /// </summary>
        private double amout;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet"/> class.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public Wallet(double amount)
        {
            this.amout = amount;
        }

        /// <summary>
        /// The calculate amount remaining for shopping.
        /// </summary>
        /// <param name="totalExpense">
        /// The total expense.
        /// </param>
        /// <returns>
        /// The System.Double.
        /// </returns>
        public double CalculateAmountRemainingForShopping(double totalExpense)
        {
            return this.amout - totalExpense;
        }
    }

    public interface IWallet
    {
        /// <summary>
        /// The calculate amount remaining for shopping.
        /// </summary>
        /// <param name="totalExpense">
        /// The total expense.
        /// </param>
        /// <returns>
        /// The System.Double.
        /// </returns>
        double CalculateAmountRemainingForShopping(double totalExpense);
    }
}