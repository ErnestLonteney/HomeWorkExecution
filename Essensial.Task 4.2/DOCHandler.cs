using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial.Task_4._2
{
    class DOCHandler : Handler
    {
        public override void Change()
        {
            Console.WriteLine("DOC has been changed");
        }

        public override void Create()
        {
            Console.WriteLine("DOC has been created");
        }

        public override void Open()
        {
            Console.WriteLine("DOC has been opened");
        }

        public override void Save()
        {
            Console.WriteLine("DOC has been saved");
        }
    }
}
