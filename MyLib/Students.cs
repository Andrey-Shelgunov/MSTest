using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    internal class Students
    {
        public string Name { get; private set; }

        public Students(string name)
        {
            Name = name;
        }
    }
}
