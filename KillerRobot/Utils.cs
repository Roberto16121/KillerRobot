
namespace KillerRobot
{
    public enum LifeFormType
    {
        Animal,
        Human,
        Superheroes
    }
    public static class Planets
    {
        public static Planet earth = new("Earth");
        public static Planet mars = new("Mars");
    }

    public static class Intensity
    {
        public static double GetKillIntensity(LifeForm Target)
        {
            double intensity = Target.GetHealth();
            return intensity > 50 ? 50 : intensity;

        }
    }
}

