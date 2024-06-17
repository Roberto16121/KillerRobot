using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerRobot
{
    public class Planet
    {
        public bool ContainsLife;
        List<LifeForm> lifeForms = new List<LifeForm>();
        public string Name { get; set; }

        public Planet(string Name)
        {
            this.Name = Name;
            Random r = new Random();
            int n = r.Next(2, 10);
            for (int i = 0; i < n; i++)
            {
                int lifeFormType = r.Next(0, 3);
                switch (lifeFormType)
                {
                    case 0:
                        lifeForms.Add(new Animal());
                        break;
                    case 1:
                        lifeForms.Add(new Human());
                        break;
                    case 2:
                        lifeForms.Add(new Superhero());
                        break;
                }
            }
            ContainsLife = true;
        }

        public List<LifeForm> GetLifeForm() => lifeForms;

        public LifeForm? GetNextTarget(List<LifeFormType> Target)
        {
            foreach (var lifeForm in lifeForms)
            {
                if(Target.Contains(lifeForm.Type))
                {
                    return lifeForm;
                }
            }
            return null;
        }


        public void RemoveLifeForm(LifeForm lifeForm)
        {
            lifeForms.Remove(lifeForm);
            if(lifeForms.Count == 0)
            {
                ContainsLife = false;
            }
        }

    }
}
