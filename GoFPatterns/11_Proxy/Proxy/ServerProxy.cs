namespace Proxy
{
    internal class ServerProxy : IServer
    {
        private readonly Server server = new Server();
        private bool resultHasBeenCalculated;
        private int cachedResult;

        public void PerformComplexCalculation()
        {
        }

        public int GetResult()
        {
            if (resultHasBeenCalculated) return cachedResult;

            server.PerformComplexCalculation();
            cachedResult = server.GetResult();
            resultHasBeenCalculated = true;

            return cachedResult;
        }
    }
}