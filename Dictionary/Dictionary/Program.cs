using Dictionary;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> informations = new MyDictionary<int, string>();
            informations.Add(12, "Ahmet");
            informations.Add(41, "Ali");
            informations.Add(20, "Ayşe");
            informations.Add(11, "Sırma");
            informations.List();
        }
    }
}
