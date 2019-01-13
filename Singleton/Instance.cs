namespace Singleton
{
    public class Instance
    {
        private static Instance _instance = null;

        private Instance()
        {
        }

        public static Instance GetInstance()
        {
            if (_instance == null)
                _instance = new Instance();

            return _instance;
        }
    }
}
