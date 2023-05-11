using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.LSP.Solved.Interfaces
{
    internal interface IManager : IEmployee
    {
        IEmployee Manager {  get; }

        void AssignManager(IEmployee manager);
    }
}
