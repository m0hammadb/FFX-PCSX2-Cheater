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
        public override MemoryAddress<byte> InventoryCounts
        {
            get
            {
                if(_inventoryCountAddress == null)
                {
                    _inventoryCountAddress = new MemoryAddress<byte>
                    {
                        BaseAddress = 0x2031D59C,
                        UpperBound = 111,
                        Skip = 0
                    };
                }

                return _inventoryCountAddress;
            }
        }

        private MemoryAddress<byte> _inventoryItemTypes;

        public override MemoryAddress<byte> InventoryItemTypes
        {
            get
            {
                if(_inventoryItemTypes == null)
                {
                    _inventoryItemTypes = new MemoryAddress<byte>
                    {
                        BaseAddress = 0x2031D39C,
                        UpperBound = 111,
                        Skip = 1
                    };

                   
                }

                return _inventoryItemTypes;
            }
        }
    }
}
