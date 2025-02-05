using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_Task_1._2
{
    internal class MounthCollection : IEnumerable
    {
        private Month[] mounthes;

        public MounthCollection()
        {
            mounthes =
            [
                new Month("Jenuarely", 1, 31),
                new Month("February", 2, 28),
                new Month("March", 3, 31)
            ];    
        }       

        public Month this[int number]
        {
            get
            {
                if (number > 0 && number <= 12)
                {
                   return mounthes.Single(x => x.Number == number);
                }

                return new Month();
            }
        }

        public IEnumerable<Month> this[string count]
        {
            get 
            {
                if (byte.TryParse(count, out byte res) && res > 0 && res <= 31)
                {
                    return mounthes.Where(m => m.CountOfDays == res);
                }

                return [];
            }
        }      

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mounthes.GetEnumerator();
        }
    }
}
