using System;
using AopAlliance.Intercept;

namespace MovieFinder
{
    public class RetryInterceptor : IMethodInterceptor
    {
        private readonly int numberOfRetries;

        public RetryInterceptor(int numberOfRetries)
        {
            this.numberOfRetries = numberOfRetries;
        }

        public object Invoke(IMethodInvocation invocation)
        {
            Exception exception = null;
            for (var i = 0; i < numberOfRetries; i++)
            {
                try
                {
                    return invocation.Proceed();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Call failed");
                    exception = e;
                }
            }

            throw exception;
        }
    }
}