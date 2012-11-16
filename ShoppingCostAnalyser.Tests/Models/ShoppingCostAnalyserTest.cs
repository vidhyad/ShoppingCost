namespace ShoppingCostAnalysis.Tests.Models
{
    using Moq;

    using NUnit.Framework;

    using ShoppingCostAnalyser.Models;

    [TestFixture]
    public class ShoppingCostAnalyserTest
    {
        private ShoppingCostAnalyser shoppingCostAnalyser;

        [SetUp]
        public void SetUp()
        {
            shoppingCostAnalyser = new ShoppingCostAnalyser(new Wallet(0.0));
        }

        [Test]
        public void ShouldReturnSumOfIndividualExpensensesAsTotalExpense()
        {
           Assert.That(shoppingCostAnalyser.CalculateTotalExpense(5, 8.2), Is.EqualTo(13.2));
        }
        [Test]
        public void ShouldInvokeWalletAndReturnAmountRemainingForShopping()
        {

            var mockWallet = new Mock<IWallet>();
            mockWallet.Setup(wallet => wallet.CalculateAmountRemainingForShopping(4)).Returns(6);
            shoppingCostAnalyser = new ShoppingCostAnalyser(mockWallet.Object);

            Assert.That(shoppingCostAnalyser.GetAmountRemainingForShopping(4), Is.EqualTo(6));

            mockWallet.Verify(wallet => wallet.CalculateAmountRemainingForShopping(4));
        }
    }
}
