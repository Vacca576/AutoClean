using System;
using Exiled.API.Features;

namespace GroundCleanupPlugin
{
    public class GroundCleanupPlugin : Plugin<Config>
    {
        private Timer _cleanupTimer;

        public override void OnEnabled()
        {
            base.OnEnabled();
            _cleanupTimer = new Timer(Cleanup, null, TimeSpan.FromMinutes(6), Timeout.InfiniteTimeSpan);
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            _cleanupTimer?.Dispose();
        }

        private void Cleanup(object state)
        {
            
            foreach (var item in Item.List)
            {
                item.Remove();
            }
            foreach (var player in Player.List)
            {
                player.Character?.Remove();
            }
            _cleanupTimer.Change(TimeSpan.FromMinutes(6), Timeout.InfiniteTimeSpan); 
        }
    }
}
