using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial.Task_4._2
{
    class TXTHandler : Handler
    {
        public override void Change()
        {
            Console.WriteLine("TXT has been changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXT has been created");
        }

        public override void Open()
        {
            Console.WriteLine("TXT has been opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXT has been saved");
        }
    }
}
