using System;
using System.Collections.Generic;
using Sim_U_Duck.Behaviors;
using Sim_U_Duck.Ducks;

namespace Sim_U_Duck
{
    public static class DuckTest
    {
        public static void Main()
        {
            //TestSortStrategy();
            TestDucks();
            Console.ReadLine();
        }

        private static void TestSortStrategy()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee("Kris", "Desmadryl", new DateTime(1990, 5, 5)));
            employees.Add(new Employee("Kris", "Desmadryl", new DateTime(1970, 5, 5)));
            employees.Add(new Employee("Kris", "Desmadryl", new DateTime(1980, 5, 5)));


            employees.Sort(new SortEmployeeByBirthDate());


            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void TestDucks()
        {
            TestDuck(new MallardDuck());
            TestDuck(new RedHeadDuck());
            TestDuck(new RubberDuck());
            TestDuck(new DecoyDuck());
            var hiTechDuck = new HiTechDuck();
            TestDuck(hiTechDuck);

            hiTechDuck.Attach(new RocketPoweredFlyBehavior());
            TestDuck(hiTechDuck);
        }

        private static void TestDuck(Duck duck)
        {
            Console.WriteLine("*** {0} ***", duck.GetType().Name);
            duck.Display();
            duck.Quack();
            duck.Fly();
            Console.WriteLine();
        }
    }

    public class SortEmployeeByBirthDate : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.DateOfBirth.CompareTo(y.DateOfBirth);
        }
    }

    public class Employee
    {
        public Employee(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", FirstName, LastName, DateOfBirth);
        }
    }

    public class RocketPoweredFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Whooooooosh");
        }
    }
}