using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotControl.CLibrary;
using DotControl.CLibrary.Interfaces;



namespace DotControl.CLibrary.Interfaces
{
    public class Account : IAccount, IAccountBalanceService, ISettingsProvider
    {
        ILogger _logger;
        private readonly Guid accountId;
        private readonly IAccountBalanceService _accountBalanceService;
        private readonly ISettingsProvider _settingsProvider;
        public double Balance { get; private set; }
        public double Balance_ { get; private set; }
        public Account(ILogger logger, Guid accountId,
        IAccountBalanceService accountBalanceService,
        ISettingsProvider settingsProvider)
        {
            _logger = logger;
            this.accountId = accountId;
            _accountBalanceService = accountBalanceService;
            _settingsProvider = settingsProvider;
        }

        public Account()
        {
        }

        public void RefreshBalance()
        {
            _logger.Log("Starting the processing of Accunting");

            Balance = _accountBalanceService.GetCurrentAccountBalance(accountId)
            * _settingsProvider.GetAccountBalanceMultiplier();

            _logger.Log("Finished processing of the balance");
        }

        public async void RefreshBalanceAsync()
        {            
            await Task.Run(() =>
            {
                Balance_ = _accountBalanceService.GetCurrentAccountBalance(accountId)
                    * _settingsProvider.GetAccountBalanceMultiplier();
            });
            
        }
        public double GetCurrentAccountBalance(Guid accountId)
        {
            return 10;
            //throw new NotImplementedException();
        }

        public double GetAccountBalanceMultiplier()
        {
            return 10;
            //throw new NotImplementedException();
        }
    }
}
