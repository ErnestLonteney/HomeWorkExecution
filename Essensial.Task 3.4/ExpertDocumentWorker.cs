using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial.Task_3._4
{
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void EditDocument() => Console.WriteLine("Document has been edited in a Expert version");
        public override void SaveDocument() => Console.WriteLine("Document has saved in a Expert version");
    }
}
