using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppC_
{
    public class student
    {
        public int Id { get; set; }
        public student Next;
        public student(int id)
        {
            Id = id;
            Next = null;
        }
       


    
    }
}
