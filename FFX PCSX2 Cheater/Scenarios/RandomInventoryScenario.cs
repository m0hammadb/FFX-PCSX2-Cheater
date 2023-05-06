using FFX_PCSX2_Cheater.Interfaces;
using FFX_PCSX2_Cheater.Libs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_PCSX2_Cheater.Scenarios
{
    public class RandomInventoryScenario : IGameScenario
    {
        private readonly FfxMethods _methodService;
        private readonly int _battleIntervals;
        private readonly int _maxInventoryItems;
        private long _nextBattleCount = -1;

        private const int EACH_ITEM_COUNT = 1;
        private bool _isCanceled = false;

        private long _currentBattleCount = -1;
        public RandomInventoryScenario(FfxMethods methodService, int battleIntervals = 10, int maxInventoryItems = 10)
        {
            if (battleIntervals <= 0)
            {
                throw new ArgumentException("Battle intervals cannot be zero or negative");
            }
            _methodService = methodService;
            _battleIntervals = battleIntervals;
            _maxInventoryItems = maxInventoryItems;
        }
        public Task Cancel()
        {
            _isCanceled = true;
            return Task.CompletedTask;
        }

        public async Task Initialize()
        {
            var currentBattleCount = _methodService.GetBattleCount();

            var remainingToTen = currentBattleCount % _battleIntervals;

            _nextBattleCount = currentBattleCount - remainingToTen + _battleIntervals;

            while (!_isCanceled)
            {

                currentBattleCount = _methodService.GetBattleCount();

                _currentBattleCount = currentBattleCount;

                if (currentBattleCount == _nextBattleCount)
                {
                    _nextBattleCount += _battleIntervals;
                    _methodService.RandomizeInventory(EACH_ITEM_COUNT, _maxInventoryItems);
                }

                // if these two conditions are met it probably means the game was changed after the scenario was started
                if(currentBattleCount >  _nextBattleCount)
                {
                    _isCanceled = true;
                }

                if(_nextBattleCount - currentBattleCount > _battleIntervals)
                {
                    _isCanceled = true;
                }


                await Task.Delay(1000);
            }
        }

        public string GetCurrentScenarioInfo()
        {
            return $"Current BattleCount: {_currentBattleCount} - Next Inventory Reset: {_nextBattleCount}"; 
        }
    }
}
