using System.Data;
using WalletDalContract;
using WalletFuncLogicContracts;
using WalletFunction;

namespace WalletFuncLogic
{
    public class WalletLogic : IWalletLogic
    {
        private readonly IWalletRepository _walletRepository;

        public WalletLogic(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void Create(RubBalance rub)
        {
            _walletRepository.Add(rub);
        }
    }
}
