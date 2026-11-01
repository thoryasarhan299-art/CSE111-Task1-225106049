using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();

            list.AddFront(20);
            list.Print();

            list.AddFront(10);
            list.Print();

            list.AddEnd(30);
            list.Print();

            list.AddEnd(40);
            list.Print();

            list.Reverse();
            list.Print();

            list.Remove(20);
            list.Print();
        }
    }
}