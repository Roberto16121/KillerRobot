

using KillerRobot;

/// <summary>
/// Killer Robot are misiunea de a elimina toate formele de viață de pe planeta Pământ.
/// Robotul are un laser în ochi cu intensitate variabilă și poate să-și selecteze țintele dintre animale si oameni
/// Misiunea robotului este de a distruge toate țintele sale
/// </summary>
class Program
{
    static void Main()
    {
        Planet earth = Planets.earth;
        var robot = new GiantKillerRobot();
        robot.Target = new List<LifeFormType>{ LifeFormType.Animal, LifeFormType.Human, LifeFormType.Superhero };
        robot.Initialize(earth);

        robot.EyeLaserIntensity = Intensity.GetKillIntensity(robot.CurrentTarget);

        Render render = new Render(robot, earth);
        render.Show();
        render.Clear();
        while(robot.Active && earth.ContainsLife)
        {
            render.Clear();
            if (robot.CurrentTarget.IsAlive)
                robot.FireLaserAt(robot.CurrentTarget);
            else
            {
                if(robot.AquireNextTarget(earth))
                    robot.EyeLaserIntensity = Intensity.GetKillIntensity(robot.CurrentTarget);
            }

             render.Show();
             Thread.Sleep(1000);
        }
        render.Over();

    }

}