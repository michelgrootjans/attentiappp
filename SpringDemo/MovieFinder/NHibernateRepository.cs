using System;
using System.Collections.Generic;

namespace MovieFinder
{
    public class NHibernateRepository : IRepository
    {
        public IEnumerable<T> Query<T>(IQuery<T> queryObject)
        {
            Console.WriteLine("Executing NHibernateRepository.Query(...)");

            var session = new DummySession();
            return queryObject.Execute(session);
        }
    }

    public class DummySession : ISession
    {
    }

}