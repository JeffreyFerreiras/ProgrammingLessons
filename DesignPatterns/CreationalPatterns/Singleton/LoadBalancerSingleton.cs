namespace DesignPatterns.CreationalPatterns.Singleton
{
    internal class LoadBalancerSingleton
    {
        private static readonly LoadBalancerSingleton _singleton;

        private LoadBalancerSingleton() {}

        public static LoadBalancerSingleton Instance()
        {
            if(_singleton == null)
            {
                return new LoadBalancerSingleton();
            }
            return _singleton;
        }

        //Very expensive code here.
    }

    class MainApp
    {
        LoadBalancerSingleton GetLoadBalancer()
        {
            var singleTonObj = LoadBalancerSingleton.Instance();
            return singleTonObj;
        }     
    }
}