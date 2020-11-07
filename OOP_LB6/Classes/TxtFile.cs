using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace OOP_LB6.Classes
{
    class TxtFile : AbstractHandler
    {
        public TxtFile(string Path) : base(Path) { }
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override string ShowText()
        {
            using (StreamReader streamReader = new StreamReader(Path, Encoding.GetEncoding("Windows-1252")))
            {
                return streamReader.ReadToEnd();
            }

        }
    }
}
