using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string searchKey = Console.ReadLine();

            int index = searchKey.IndexOf(key);

            while (searchKey.Contains(key))
            {
                searchKey = searchKey.Remove(index, key.Length);
                index = searchKey.IndexOf(key);
            }

            Console.WriteLine(searchKey);
        }
    }
}
