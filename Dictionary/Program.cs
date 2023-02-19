using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> numbername = new MyDictionary<int, string>();
            numbername.Add(1, "One");
            numbername.Add(2, "Two");
            numbername.Add(3, "Three");
        }
    }
}
