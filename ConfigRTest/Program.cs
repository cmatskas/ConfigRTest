using System;
using ConfigR;

namespace ConfigRTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            var name = Config.Global.Get<string>("Name");
            var age = Config.Global.Get<int>("Age");
            var forReal = Config.Global.Get<bool>("IsThisYourAge");
            var actualAge = Config.Global.Get<int>("MyRealAge");
            var getMore = Config.Global.Get<Uri>("CheckTheSourceCode");
            var foo = Config.Global.Get<Foo>("Foo");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("For Real?: {0}", forReal);
            Console.WriteLine("Actual Age: {0}", actualAge);
            Console.WriteLine("Where can I get more?: {0}", getMore);
            Console.WriteLine("The Foo Bar {0} and date {1}", foo.Bar, foo.BarDateTime);
            Console.ReadLine();
        }
    }
}
