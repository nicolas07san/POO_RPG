namespace POO_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level)
        {
            this.name =  name;
            this.level = level;

            baseHealthPoints = 80;
            baseManaPoints = 20;

            manaIncreasePerLevel = 10;
            healthIncreasePerLevel = 20; 

            maxHealthPoints = baseHealthPoints + (healthIncreasePerLevel * level);
            healthPoints =  maxHealthPoints;

            maxManaPoints = baseManaPoints + (manaIncreasePerLevel * level);
            manaPoints = maxManaPoints;

        }
    }
}