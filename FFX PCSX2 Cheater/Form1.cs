using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Native;
using FFX_PCSX2_Cheater.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FFX_PCSX2_Cheater
{
    public partial class Form1 : Form
    {
        

       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ps = Process.GetProcessesByName("pcsx2").First();

            var result = WinAPI.ReadMem<Int16>(ps, 0x2031D59F);

            
        }
    }
}