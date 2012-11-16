namespace ShoppingCostAnalysis.Tests.Models
{
    using NUnit.Framework;

    using ShoppingCostAnalyser.Models;

    [TestFixture]
    public class WalletTest
    {
        private Wallet wallet;

        [Test]
        public void ShouldReturnDifferenceBetweenExpensensesAsAmountRemainingForShopping()
        {
            wallet = new Wallet(10);
            Assert.That(wallet.CalculateAmountRemainingForShopping(4), Is.EqualTo(6));
        }
    }
}
