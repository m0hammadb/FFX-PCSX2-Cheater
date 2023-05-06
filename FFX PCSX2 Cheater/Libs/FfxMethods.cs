using FFX_PCSX2_Cheater.Addresses;
using FFX_PCSX2_Cheater.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Libs
{
    public class FfxMethods
    {
        private readonly FfxAddresses _addressLibrary;
        private readonly Process _process;

        public FfxMethods(FfxAddresses addressLibrary, Process process)
        {
            _addressLibrary = addressLibrary;
            _process = process;
        }

        public short GetBattleCount()
        {
            var result = WinAPI.ReadMem<short>(_process, _addressLibrary.BattlesCount.BaseAddress);

            return result.ToShort();
        }

        public void RandomizeInventory(byte count = 1,int maxCount=10)
        {
            var ps = _process;
            Random r = new Random();
            for (int i = 0; i <= maxCount; i++)
            {

                WinAPI.WriteMem(ps, _addressLibrary.InventoryItemTypes[i], new byte[] { (byte)r.Next(0, 100) });
                WinAPI.WriteMem(ps, _addressLibrary.InventoryCounts[i], new byte[] { count });
            }

            for(int i=maxCount; i<= _addressLibrary.InventoryCounts.UpperBound; i++)
            {
                WinAPI.WriteMem(ps, _addressLibrary.InventoryItemTypes[i], new byte[] { 0 });
                WinAPI.WriteMem(ps, _addressLibrary.InventoryCounts[i], new byte[] { 0 });
            }
        }
    }
}
