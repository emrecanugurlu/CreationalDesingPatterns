namespace SingletonDesignPatternAspNetCore.Services
{
    public class DbService
    {
        private DbService() {
            Console.WriteLine($"{nameof(DbService)} nesnesi oluşturuldu.");
        }

        private static DbService _instance;

        public static DbService GetInstance 
            {
                get 
                {
                    if (_instance == null)
                        _instance = new DbService();
                    return _instance;
                }
            }

        public int Count;
        public bool Connection()
        {
            Console.WriteLine("Bağlantı Sağlandı");
            Count++;
            return true;
        }
        public bool DeConnection()
        {
            Console.WriteLine("Bağlantı Kesildi");
            Count++;
            return false;
        }
    }
}
