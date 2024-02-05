using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WalletFunction;
using static WalletFunction.Amount;

namespace WalletFuncLogicContracts
{
    public interface IWalletLogic
    {
        public void Create(AmountType type);

    }
}
