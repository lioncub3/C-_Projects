using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bank;
using static Bank.Account;

namespace Bank_Test
{
    public class TestAccount
    {
        private Account src = null;
        private Account dst = null;
        public TestAccount()
        {
            src = new Account();
            src.Deposit(100.00);
            dst = new Account();
            dst.Deposit(150.00);
        }

        [Fact]
        public void TestTransfer()
        {
            src.Transfer(dst, 50.00);
            Assert.Equal(50.00, src.Balance);
            Assert.Equal(200.00, dst.Balance);
        }

        [Fact]
        public void TestOverdraft()
        {
            Assert.Throws<OverdraftException>(() => src.Transfer(dst, 95.00));
            //src.Transfer(dst, 95.00);
            //Assert.Equal(5.00, src.Balance);
            //Assert.Equal(245.00, dst.Balance);
        }

        [Fact]
        public void TestFailedTransfer()
        {
            try
            {
                src.Transfer(dst, 95.00);
            }
            catch (OverdraftException ex)
            {
                
            }
            Assert.Equal(100.00, src.Balance);
            Assert.Equal(150.00, dst.Balance);
        }

        [Fact(Skip = "Перевірка на атомарність")]
        public void TestAtom()
        {
            
        }
    }
}
