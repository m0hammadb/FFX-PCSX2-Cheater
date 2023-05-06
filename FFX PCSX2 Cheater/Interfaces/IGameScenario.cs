using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Interfaces
{
    public interface IGameScenario
    {
        public Task Initialize();

        public Task Cancel();

        public string GetCurrentScenarioInfo();
    }
}
