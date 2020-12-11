using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotControl.CLibrary.Interfaces;

namespace DotControl.CLibrary
{
   public class BetterAccount : IAccount
    {
        ILogger _logger;
        private readonly Guid _accountId;
        private readonly IAccountBalanceService _accountBalanceService;
        private readonly ISettingsProvider _settingsProvider;
        public double Balance { get; private set; }
        public BetterAccount(ILogger logger, Guid accountId,
        IAccountBalanceService accountBalanceService,
        ISettingsProvider settingsProvider)
        {
            _logger = logger;
            _accountId = accountId;
            _accountBalanceService = accountBalanceService;
            _settingsProvider = settingsProvider;
        }
        public void RefreshBalance()
        {
            _logger.Log("Starting the processing of Accunting");
            Console.WriteLine("---");
            Balance = _accountBalanceService.GetCurrentAccountBalance(_accountId)
            * _settingsProvider.GetAccountBalanceMultiplier();
            
            Console.WriteLine("---");
            _logger.Log("Finished processing of the balance");
            Console.WriteLine("---");
        }

        public double GetCurrentAccountBalance(Guid accountId)
        {
            return 100;
            //throw new NotImplementedException();
        }

        public double GetAccountBalanceMultiplier()
        {
            return 100;
            //throw new NotImplementedException();
        }
    }
}
