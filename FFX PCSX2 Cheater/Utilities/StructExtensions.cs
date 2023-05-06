using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Utilities
{
    public static class StructExtensions
    {
        public static short ToShort(this byte[] bytes)
        {
            if(bytes.Length != 2)
            {
                throw new ArgumentException("Invalid length");
            }

            byte port1 = bytes[0];
            byte port2 = bytes[1];

            ushort value = BitConverter.ToUInt16(new byte[2] { (byte)port1, (byte)port2 }, 0);

            return (short)value;
        }
    }
}
