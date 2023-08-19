using IntegrateMoMo.Models.Momo;
using IntegrateMoMo.Models.Order;
using IntegrateMoMo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegrateMoMo.Controllers
{
    [Route("api/momo")]
    [ApiController]
    public class MomoController : ControllerBase
    {
        private readonly IMomoService _momoService;

        public MomoController(IMomoService momoService)
        {
            _momoService = momoService;
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreatePaymentUrl(OrderInfoModel model)
        {
            var res = await _momoService.CreatePaymentAsync(model);
            return res.PayUrl;
        }
        [HttpGet("return")]
        public ActionResult<MomoExecuteResponseModel> PaymentCallBack()
        {
            var response = _momoService.PaymentExecuteAsync(HttpContext.Request.Query);
            return response;
        }
    }
}
