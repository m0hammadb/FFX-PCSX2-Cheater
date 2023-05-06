using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Native;
using FFX_PCSX2_Cheater.Addresses;
using FFX_PCSX2_Cheater.Interfaces;
using FFX_PCSX2_Cheater.Libs;
using FFX_PCSX2_Cheater.Scenarios;
using FFX_PCSX2_Cheater.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FFX_PCSX2_Cheater
{
    public partial class Form1 : Form
    {

        private FfxAddresses _addressLib = new PbirdmodAddresses();

        private IGameScenario? _currentScenario = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRandomInventoryStarter_Click(object sender, EventArgs e)
        {
            var ps = Process.GetProcessesByName("pcsx2").FirstOrDefault();

            if (ps == null)
            {
                MessageBox.Show("Process pcsx2 not found!");
                return;
            }

            var util = new FfxMethods(_addressLib, ps);

            var randomScenario = new RandomInventoryScenario(util);

            _currentScenario = randomScenario;

            ApplyScenarioChanges();
            await randomScenario.Initialize();
            btnRandomInventoryStarter.Enabled = true;
        }

        private void btnCancelScenario_Click(object sender, EventArgs e)
        {
            if (_currentScenario != null)
            {
                _currentScenario.Cancel();
                _currentScenario = null;
            }
            btnCancelScenario.Enabled = false;
        }

        private void ApplyScenarioChanges()
        {
            btnRandomInventoryStarter.Enabled = false;

            btnCancelScenario.Enabled = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_currentScenario == null)
            {
                return;
            }

            lblScenarioStatus.Text = _currentScenario.GetCurrentScenarioInfo();
        }
    }
}