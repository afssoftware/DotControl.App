using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotControl.CLibrary.Interfaces;
using DotControl.CLibrary;

namespace DotControl.UI
{
    public class Application : IApplication
    {
        IAccount _account;
        public Application(IAccount account)
        {
            _account = account;
        }

        public void Run()
        {
            _account.RefreshBalance();
        }
   
    }
}
