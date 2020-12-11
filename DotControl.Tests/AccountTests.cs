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
        public double Balance_ { get; private set; }
        string _customMessage = "custom message error";
        public AccountTests(ILogger logger, Guid accountId,
        IAccountBalanceService accountBalanceService,
        ISettingsProvider settingsProvider)
        {
            _logger = logger;
            _accountId = accountId;
            _accountBalanceService = accountBalanceService;
            _settingsProvider = settingsProvider;
        }

        public Guid GuidGeneratorTest()
        {
           Guid  output =  Guid.NewGuid();
            return output;
        }
      
        [Fact(DisplayName = "Call RefreshBalance function")]
        public void RefreshBalance_SimpleValuesShouldBlance()
        {
            // arrange

            Guid obj = GuidGeneratorTest();
            Console.WriteLine("New Guid is " + obj.ToString());
           
            // act
            var actual= new Account();
            actual.RefreshBalance();


            // assert
            Assert.Equal(expected:0, actual.Balance);
        }

        
        [Fact(DisplayName = "Call RefreshBalance Async and return errors")]
        public async void RefreshBalanceAsync__SimpleValuesShouldBlanceAsync()
        {
            // arrange
            Exception ex = await Record.ExceptionAsync(() => ThrowAnError());
            // act
            await Task.Run(() =>
            {
                Balance_ = _accountBalanceService.GetCurrentAccountBalance(_accountId)
                    * _settingsProvider.GetAccountBalanceMultiplier();
            });

            // assert
            Assert.Equal(_customMessage, ex.Message);

        }

        private Task ThrowAnError()
        {
            throw new NotImplementedException();
        }
    }
}
