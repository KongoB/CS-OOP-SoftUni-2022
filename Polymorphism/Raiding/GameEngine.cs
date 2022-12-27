using Raiding.Heroes;

namespace Raiding
{
    public class GameEngine
    {
        public static void StartGame()
        {
            
            string[] availableClasses = 
            { "Paladin", "Druid", "Rogue", "Warrior" };

            int numberOfHeroes = int.Parse(Console.ReadLine());

            List<BaseHero> raidGroup = new List<BaseHero>();

            


            for (int i = 0; i < numberOfHeroes; i++)
            {

                string heroName = Console.ReadLine();
                string heroClass = Console.ReadLine();

                if (availableClasses.Contains(heroClass))
                {

                    switch (heroClass)
                    {
                        case "Druid":
                            raidGroup.Add(new Druid(heroName));
                            break;
                        case "Paladin":
                            raidGroup.Add(new Paladin(heroName));
                            break;
                        case "Rogue":
                            raidGroup.Add(new Rogue(heroName));
                            break;
                        case "Warrior":
                            raidGroup.Add(new Warrior(heroName));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }

            }

            int bossPower = int.Parse(Console.ReadLine());
            int partyPower = 0;

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                partyPower += hero.Power;
            }

            if (partyPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }


        }

    }
}
