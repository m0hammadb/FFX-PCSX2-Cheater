using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Models
{
    public class Memory<T> where T: struct
    {
        public IntPtr Address { get; set; }

        //public T Value 
        //{ 
        //    get
        //    {

        //    } 
        //    set
        //    {

        //    }
        //}
    }
}
