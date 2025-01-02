using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial.Task_4._2
{
    abstract class Handler : IProtectable
    {
        private string status;

        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

        public void Protect()
        {
            lock (this)
            {
                status = string.Empty;
            }
        }
    }
}
