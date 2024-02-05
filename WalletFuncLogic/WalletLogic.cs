using System.Data;
using WalletDalContract;
using WalletFuncLogicContracts;
using WalletFunction;
using WalletsEnum;

namespace WalletFuncLogic
{
    public class WalletLogic : IWalletLogic
    {
        private readonly IWalletRepository _walletRepository;

        public WalletLogic(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void Create(Amount.AmountType type)
        {
           
            _walletRepository.Add(type);
        }
    }
}
