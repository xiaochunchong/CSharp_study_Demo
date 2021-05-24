using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Hashtable ht = new Hashtable(); 
            ArrayList aList = new ArrayList();
            List<string> bList = new List<string>();
            aList.Add("a");
            aList.Add("b");
            aList.Add("c");
            aList.Add("d");
            aList.Add("e");
            aList.Insert(3,"123456");
            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
