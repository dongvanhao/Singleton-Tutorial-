using System;

namespace SingletonExample.Services
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();

        public string DatabaseConnectionString { get; private set; }
        public string PaymentGatewayUrl { get; private set; }
        public string ApiKey { get; private set; }

        // Constructor private để ngăn chặn việc tạo nhiều instance
        private ConfigurationManager()
        {
            Console.WriteLine(" Cau hinh dang duoc tai...");

            // Giả lập đọc cấu hình từ file hoặc database (chỉ chạy 1 lần)
            DatabaseConnectionString = "Server=localhost;Database=ShopDB;User Id=admin;Password=1234;";
            PaymentGatewayUrl = "https://paymentgateway.com/api";
            ApiKey = "SECRET-API-KEY-12345";
        }

        // Đảm bảo chỉ có một instance duy nhất
        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) // Đảm bảo thread-safe
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
            }
            return _instance;
        }
    }
}
