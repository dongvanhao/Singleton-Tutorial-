namespace SingletonExample.Services
{
    public class OrderService
    {
        private readonly ConfigurationManager _config;

        public OrderService()
        {
            _config = ConfigurationManager.GetInstance(); // Sử dụng Singleton
        }

        public string GetPaymentGatewayUrl()
        {
            return _config.PaymentGatewayUrl;
        }

        public string GetDatabaseConnectionString()
        {
            return _config.DatabaseConnectionString;
        }
    }
}
