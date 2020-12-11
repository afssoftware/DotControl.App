using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotControl.CLibrary.Interfaces
{
    public interface IAccountBalanceService
    {
        double GetCurrentAccountBalance(Guid accountId);
    }
}
