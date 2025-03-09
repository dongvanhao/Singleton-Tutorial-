using Microsoft.AspNetCore.Mvc;
using SingletonExample.Services;

namespace SingletonExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly OrderService _orderService;

        public ConfigController()
        {
            _orderService = new OrderService();
        }

        [HttpGet("payment-url")]
        public ActionResult<string> GetPaymentGatewayUrl()
        {
            return Ok(_orderService.GetPaymentGatewayUrl());
        }

        [HttpGet("db-connection")]
        public ActionResult<string> GetDatabaseConnectionString()
        {
            return Ok(_orderService.GetDatabaseConnectionString());
        }
    }
}
