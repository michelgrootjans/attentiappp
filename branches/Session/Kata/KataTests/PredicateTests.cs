using System;
using System.Collections.Generic;
using System.Linq;
using KataTests.Extensions;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class PredicateTests
    {
        [Test]
        public void PredicateTest()
        {
            Predicate<string> startsWithK = s => s.StartsWith("K");
            Console.WriteLine("Kris starts with K: " + startsWithK("Kris"));
            Console.WriteLine("Michel starts with K: " + startsWithK("Michel"));
        }

        [Test]
        public void TestName()
        {
            var names = new List<string> { "Kris", "Tim", "Michel", "Vincent" };
            Predicate<string> startsWithK = s => s.StartsWith("K");
            foreach (var name in names.FindAll(startsWithK))
            {
                Console.WriteLine(name);
            }
        }

        [Test]
        public void PutItAllTogether()
        {
            IEnumerable<string> names = new List<string> { "Kris", "Tim", "Michel", "Vincent" };
            Predicate<string> startsWithK = s => s.StartsWith("K");
            Action<string> print = s => Console.WriteLine(s);

            names.Where(s => s.Length > 5).ForEach(print);
            Console.WriteLine(names.All(n => n.Length > 2));

            var names2 = from name in names
                         where name.Length > 2
                         orderby name
                         select name.ToUpper();

            names2.ForEach(print);

            string hello = null;

            if(string.IsNullOrEmpty(hello))
                Console.WriteLine("Object is null");
            
            if(hello.IsNullOrEmpty())
                Console.WriteLine("Object is null");
        }


    }
}