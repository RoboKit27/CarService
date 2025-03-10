namespace CarServiceSite.DAL
{
    public class SingleContext
    {
        public Context Context { get; set; }

        private static SingleContext _instance;

        private SingleContext()
        {
            Context = new Context();
        }

        public static SingleContext GetInstance()
        {
            if (_instance is null)
            {
                _instance = new SingleContext();
            }

            return _instance;
        }
    }
}
