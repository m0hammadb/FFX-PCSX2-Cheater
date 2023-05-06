using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Models
{
    public class MemoryAddress<T> where T: struct
    {
        public IntPtr BaseAddress { get; set; }

        public int UpperBound { get; set; }
        
        public IntPtr this[int index]
        {
            get
            {
                if(index > UpperBound)
                {
                    throw new ArgumentOutOfRangeException("Index out of memory location");
                }
                return BaseAddress + index;
            }
        }
    }
}
