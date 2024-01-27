using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletFunction;

namespace WalletDalContract
{
    public interface IWalletRepository
    {
        public void Add(RubAccount rub);
    }
}
