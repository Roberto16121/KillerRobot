using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerRobot
{
    internal class Render
    {
        GiantKillerRobot robot;
        Planet planet;
        public Render(GiantKillerRobot robot, Planet planet)
        {
            this.robot = robot;
            this.planet = planet;
        }
        public void Clear()
        {
            Console.Clear();
        }


        public void Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("   Type        |    Health \n");
            sb.Append("-------------- | --------------\n");
            sb.Append("Planet info : \n");
            foreach (var lifeForm in planet.GetLifeForm())
            {
                if(lifeForm.IsAlive)
                {
                    sb.Append($"{lifeForm.Type.ToString(), -14} | {lifeForm.GetHealth().ToString(), 14}\n");
                }
            }
            sb.Append("\n");
            sb.Append("Robot info : \n");
            sb.Append($"Eye laser intensity : {robot.EyeLaserIntensity} \n");
            double health = robot.CurrentTarget.GetHealth();
            string output = health < 0 ? "Dead" : health.ToString();
            sb.Append($"Current target : {robot.CurrentTarget.Type.ToString()} | {output} \n");

            Console.WriteLine(sb.ToString());
        }

        public void Over()
        {
            Console.Clear();
            Console.WriteLine("  ██████  ██▓ ███▄ ▄███▓ █    ██  ██▓    ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████   ███▄    █ \r\n" +
                "▒██    ▒ ▓██▒▓██▒▀█▀ ██▒ ██  ▓██▒▓██▒   ▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒ ██ ▀█   █ \r\n" +
                "░ ▓██▄   ▒██▒▓██    ▓██░▓██  ▒██░▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒▓██  ▀█ ██▒\r\n" +
                "  ▒   ██▒░██░▒██    ▒██ ▓▓█  ░██░▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░▓██▒  ▐▌██▒\r\n" +
                "▒██████▒▒░██░▒██▒   ░██▒▒▒█████▓ ░██████▒▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░▒██░   ▓██░\r\n" +
                "▒ ▒▓▒ ▒ ░░▓  ░ ▒░   ░  ░░▒▓▒ ▒ ▒ ░ ▒░▓  ░▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n" +
                "░ ░▒  ░ ░ ▒ ░░  ░      ░░░▒░ ░ ░ ░ ░ ▒  ░ ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n" +
                "░  ░  ░   ▒ ░░      ░    ░░░ ░ ░   ░ ░    ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░   ░ ░ \r\n" +
                "      ░   ░         ░      ░         ░  ░     ░  ░         ░      ░ ░           ░ \r\n" +
                "                                                                                  \r\n" +
                " ▒█████   ██▒   █▓▓█████  ██▀███                                                  \r\n" +
                "▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒                                                \r\n" +
                "▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒                                                \r\n" +
                "▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄                                                  \r\n" +
                "░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒                                                \r\n" +
                "░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░                                                \r\n" +
                "  ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░                                                \r\n" +
                "░ ░ ░ ▒       ░░     ░     ░░   ░                                                 \r\n" +
                "    ░ ░        ░     ░  ░   ░                                                     \r\n" +
                "              ░                                                                   ");
        }
    }
}
