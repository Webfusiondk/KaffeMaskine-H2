using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    abstract class Bevearges
    {
        string name;
        public string Name { get => name; set => name = value; }

        public Bevearges(string name)
        {
            Name = name;
        }
    }
}
