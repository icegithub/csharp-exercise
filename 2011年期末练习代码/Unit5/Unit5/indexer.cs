using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit5
{
    class Z
    {
        private long[] arr = new long[100];
        public long this[int index]
        {
            get
            {
                if (index < 0 || index >= 100)
                    return arr[0];
                else
                    return arr[index];
            }
            set
            {
                if(index )
            }
        }
    }
}
