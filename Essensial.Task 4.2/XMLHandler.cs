using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial.Task_4._2
{
    class XMLHandler : Handler
    {
        public override void Change()
        {
            Console.WriteLine("XML has been changed");
        }

        public override void Create()
        {
            Console.WriteLine("XML has been created");
        }

        public override void Open()
        {
            Console.WriteLine("XML has been opened");
        }

        public override void Save()
        {
            Console.WriteLine("XML has been saved");
        }
    }
}
