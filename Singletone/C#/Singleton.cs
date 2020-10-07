using System;
using System.Collections.Generic;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private Dictionary<string,int> UrlsList { get; set; }

        public static Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }

        private Singleton()
        {
            UrlsList = new Dictionary<string, int>();
        }
        public void AddUrl(string url)
        {
            if (UrlsList.ContainsKey(url))
                UrlsList[url] += 1;
            else
                UrlsList.Add(url,1);
        }

        public void PrintAll()
        {
            foreach (var url in UrlsList)
                Console.WriteLine(url);
        }
        public void ClearAll()
        {
            UrlsList.Clear();
            Console.WriteLine("Cleared");
        }
    }
}