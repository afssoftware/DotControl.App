using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotControl.CLibrary.Interfaces
{
    public interface IAccount
    {
        double Balance { get; }

        double GetAccountBalanceMultiplier();
        //void Log(string message);
        void RefreshBalance();
    }
}
