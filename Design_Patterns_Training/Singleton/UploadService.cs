namespace Design_Patterns_Training.Singleton
{
    public sealed class UploadService
    {
        private static UploadService _instance;
        private static readonly object _lock = new object();
        public string Message { get; private set; }

        private UploadService() { }

        public static UploadService GetInstance(string message)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UploadService();
                        _instance.Message = message;
                    }
                }
            }

            return _instance;
        }
    }
}
