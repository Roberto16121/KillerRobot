using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerRobot
{
    internal class GiantKillerRobot
    {
        public bool Active;
        public double EyeLaserIntensity { get; set; }
        public List<LifeFormType> Target { get; set; }
        public LifeForm CurrentTarget { get; set; }

        public void Initialize(Planet currentPlanet)
        {
            Active = true;
            EyeLaserIntensity = 0.5;
            AquireNextTarget(currentPlanet);
        }

        public bool AquireNextTarget(Planet currentPlanet)
        {
            currentPlanet.RemoveLifeForm(CurrentTarget);
            var TemporaryTarget = currentPlanet.GetNextTarget(Target);
            if (TemporaryTarget == null)
            {
                Active = false;
                return false;
            }
            else
                CurrentTarget = TemporaryTarget;
            return true;
        }

        public void FireLaserAt(LifeForm target)
        {
            target.TakeDamage(EyeLaserIntensity);
        }
    }
}
