using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton single = Singleton.GetInstance();
            single.AddUrl("google.com");
            single.AddUrl("google.com");
            single.AddUrl("google.com");
            single.AddUrl("unity.com");
            single.AddUrl("unity.com");
            single.AddUrl("telegram.com");
            single.PrintAll();
            single.ClearAll();
            Console.WriteLine("---clear---");
            single.AddUrl("telegram.com");
            single.PrintAll();
        }
    }
}
