using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Native;
using FFX_PCSX2_Cheater.Addresses;
using FFX_PCSX2_Cheater.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FFX_PCSX2_Cheater
{
    public partial class Form1 : Form
    {

        private FfxAddresses _addressLib = new PbirdmodAddresses();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ps = Process.GetProcessesByName("pcsx2").First();
            Random r = new Random();
            for(int i=0; i<=_addressLib.InventoryCountAddress.UpperBound; i++)
            {

                WinAPI.WriteMem(ps, _addressLib.InventoryCountAddress[i], new byte[] { (byte)r.Next(0,100) });
            }

            var result = WinAPI.ReadMem<byte>(ps, 0x2031D59F);

            
        }
    }
}