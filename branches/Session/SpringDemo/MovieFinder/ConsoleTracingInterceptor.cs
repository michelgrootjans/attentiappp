using System;
using AopAlliance.Intercept;

namespace MovieFinder
{
    public class ConsoleTracingInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            var method = string.Format("{0}.{1}", invocation.Target.GetType().Name, invocation.Method.Name);

            Console.WriteLine("{0} Before method {1} ...",DateTime.Now, method);
            var proceed = invocation.Proceed();
            Console.WriteLine("{0} Method {1} ...", DateTime.Now, method);
            return proceed;
        }
    }
}