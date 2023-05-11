using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.LSP.Solved.Interfaces
{
    internal interface IEmployee
    {
        public string ID { get; set; }
        public string Name { get; set; }

        void PrintDetails();
    }
}
