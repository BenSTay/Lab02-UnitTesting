using System;
using Xunit;
using BankApp;

namespace BankTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 9, 10)]
        [InlineData(1.11, 2.22, 3.33)]
        [InlineData(1.11, -2.22, -1.11)]
        [InlineData(0, 0, 0)]
        public void TestAddMoney(decimal balance, decimal balanceAdded, decimal expected)
        {
            Assert.Equal(expected, Program.AddMoney(balance, balanceAdded));
        }

        [Theory]
        [InlineData(9, 1, 8)]
        [InlineData(1.11, -2.22, 3.33)]
        [InlineData(0, 0, 0)]
        public void TestWithdrawal(decimal balance, decimal balanceWithdrawn, decimal expected)
        {
            Assert.Equal(expected, Program.WithdrawMoney(balance, balanceWithdrawn));
        }

        [Fact]
        public void TestOverdraw()
        {
            Assert.Throws<Exception>(() => Program.WithdrawMoney(0, 1));
        }
    }
}
