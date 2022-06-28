namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public static class ConnectionStringExptension
    {
        private static string _connectionString;

        public static void setConnectionString(this string str, string value)
        {
            _connectionString = value;
        }

        public static string getConnectionString(this string str)
        {
            return _connectionString;
        }

        private static int _maxRetryCount=10;

        public static int MaxRetryCount(this string str) { return _maxRetryCount; }
    }
}
