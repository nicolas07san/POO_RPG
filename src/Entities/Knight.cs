namespace POO_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level)
        {
            this.name = name;
            this.level = level;

            baseHealthPoints = 150;
            baseManaPoints = 15;

            manaIncreasePerLevel = 5;
            healthIncreasePerLevel = 20; 

            maxHealthPoints = baseHealthPoints + (healthIncreasePerLevel * level);
            healthPoints =  maxHealthPoints;

            maxManaPoints = baseManaPoints + (manaIncreasePerLevel * level);
            manaPoints = maxManaPoints;

        }
    }
}