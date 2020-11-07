using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB6.Classes
{
    abstract class AbstractHandler
    {
        public AbstractHandler(string Path)
        {
            this.Path = Path;
        }
        public string Path { get; set; }
        abstract public void Edit();
        abstract public string ShowText();
    }
}
