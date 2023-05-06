using FFX_PCSX2_Cheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Addresses
{
    public class PbirdmodAddresses : FfxAddresses
    {
        private MemoryAddress<byte> _inventoryCountAddress;
        public override MemoryAddress<byte> InventoryCountAddress
        {
            get
            {
                if(_inventoryCountAddress == null)
                {
                    _inventoryCountAddress = new MemoryAddress<byte>
                    {
                        BaseAddress = 0x2031D59C,
                        UpperBound = 111
                    };
                }

                return _inventoryCountAddress;
            }
        }


    }
}
