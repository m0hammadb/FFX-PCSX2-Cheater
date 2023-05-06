using FFX_PCSX2_Cheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Addresses
{
    public abstract class FfxAddresses
    {
        public abstract MemoryAddress<byte> InventoryCountAddress { get; }
    }
}
