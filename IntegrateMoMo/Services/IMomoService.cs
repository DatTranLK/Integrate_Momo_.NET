using IntegrateMoMo.Models.Momo;
using IntegrateMoMo.Models.Order;

namespace IntegrateMoMo.Services
{
    public interface IMomoService
    {
        Task<MomoCreatePaymentResponseModel> CreatePaymentAsync(OrderInfoModel model);
        MomoExecuteResponseModel PaymentExecuteAsync(IQueryCollection collection);
    }
}
