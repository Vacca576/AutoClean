using System;
using Exiled.API.Features;

namespace WelcomeMessage
{
    public class WelcomeMessagePlugin : Plugin<Config>
    {
        public override string Name => "AutoClean";
        public override string Author => "Vacca";
        public override string Prefix => "AutoClean";
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        public override void OnEnabled()
        {
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            
            base.OnDisabled();
        }

  
            }
            _cleanupTimer.Change(TimeSpan.FromMinutes(6), Timeout.InfiniteTimeSpan); 
        }
    }
}
