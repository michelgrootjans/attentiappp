using System.Collections.Generic;

namespace MovieFinder
{
    public interface IRepository
    {
        IEnumerable<T> Query<T>(IQuery<T> queryObject);
    }

    public interface IQuery<T>
    {
        IEnumerable<T> Execute(ISession session);
    }

    public interface ISession
    {
    }
}