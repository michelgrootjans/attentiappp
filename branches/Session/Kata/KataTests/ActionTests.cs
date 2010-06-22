using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class ActionTests
    {
        [Test]
        public void SimpleActionWithDelegate()
        {
            Action print = delegate { Console.WriteLine("Hello world"); };
            print();
        }

        [Test]
        public void SimpleActionWithLambda()
        {
            Action print = () => Console.WriteLine("Hello world");
            print();
        }

        [Test]
        public void TypedActionWithDelegate()
        {
            Action<string> print = delegate(string s) { Console.WriteLine(s); };
            print("Hello world");
        }

        [Test]
        public void TypedActionWithLambda()
        {
            Action<string> print = s => Console.WriteLine(s);
            print("Hello world");
        }

        [Test]
        public void ListApplication()
        {
            var names = new List<string> {"Kris", "Tim", "Michel", "Vincent"};
            Action<string> print = s => Console.WriteLine(s);
            Action<string> printUppercase = s => Console.WriteLine(s.ToUpper());
            Execute(names, print);
            Execute(names, printUppercase);
        }

        private void Execute<T>(List<T> list, Action<T> action)
        {
            list.ForEach(action);
        }
    }
}