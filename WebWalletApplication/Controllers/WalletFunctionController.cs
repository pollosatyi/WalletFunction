using Microsoft.AspNetCore.Mvc;
using WalletFuncLogicContracts;
using WalletFunction;


namespace WebWalletApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletFunctionController : Controller
    {

        private readonly IWalletLogic _walletLogic;
        
        public WalletFunctionController(IWalletLogic walletLogic)
        {
            _walletLogic = walletLogic;
        }
        [HttpPost]
        public void Post([FromBody] RubBalance rub)
        {
            _walletLogic.Create(rub);
        }
          
    }
}
