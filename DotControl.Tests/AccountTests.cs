using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotControl.CLibrary;
using DotControl.CLibrary.Interfaces;
using Xunit;

namespace DotControl.Tests
{    
    public class AccountTests
    {

        ILogger _logger;
        private readonly Guid _accountId;
        private readonly IAccountBalanceService _accountBalanceService;
        private readonly ISettingsProvider _settingsProvider;
        
        public AccountTests(ILogger logger, Guid accountId,
        IAccountBalanceService accountBalanceService,
        ISettingsProvider settingsProvider)
        {
            _logger = logger;
            _accountId = accountId;
            _accountBalanceService = accountBalanceService;
            _settingsProvider = settingsProvider;
        }

      
        [Fact(DisplayName = "Call RefreshBalance function")]
        public void RefreshBalance_SimpleValuesShouldBlance()
        {
            // arrange
            double expected;
            Guid obj = Guid.NewGuid();
            Console.WriteLine("New Guid is " + obj.ToString());
           
            // act
            var actual= new Account();
            actual.RefreshBalance();


            // assert
           // Assert.Equal(expected, actual.Balance);
        }

        
        [Fact(DisplayName = "Call RefreshBalance Async")]
        public void RefreshBalanceAsync__SimpleValuesShouldBlanceAsync()
        {
            // arrange

            // act

            // assert
        }
    }
}
